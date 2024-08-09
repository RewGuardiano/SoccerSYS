using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using SoccerSYS.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SoccerSYS
{
    public partial class frmUpdateFixture : Form
    {
      
        public frmUpdateFixture()
        {
            InitializeComponent();
        }

        private void btnBackbutton_Click(object sender, EventArgs e)
        {
            frmMainMenu to = new frmMainMenu();
            to.Show();
            this.Close();
        }

        private void frmUpdateFixture_Load(object sender, EventArgs e)
        {

            cobTeamID.Items.Clear();
            List<string> awayTeamIDs = GetAllAwayTeamIDs();
            cobTeamID.Items.AddRange(awayTeamIDs.ToArray());

            List<string> fixtureIDs = GetAllFixtureIDs();

            // Add the event handler for the SelectionChanged event
            grdTeams.SelectionChanged += new EventHandler(grdTeams_SelectionChanged);


            // Load data into the DataGridView when the form loads
            gridbind();
        }

        private List<string> GetAllFixtureIDs()
        {
            List<string> fixtureIDs = new List<string>();

            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
                {
                    conn.Open();
                    string query = "SELECT Fixture_ID FROM Fixtures";
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                fixtureIDs.Add(reader["Fixture_ID"].ToString());
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching Fixture_IDs: " + ex.Message);
            }

            return fixtureIDs;
        }
        private List<string> GetAllAwayTeamIDs()
        {
            List<string> awayTeamIDs = new List<string>();

            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
                {
                    conn.Open();

                    
                    string query = "SELECT AwayTeam_ID FROM AwayTeams";
                

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                awayTeamIDs.Add(reader["AwayTeam_ID"].ToString());
                            }
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching AwayTeam_IDs: " + ex.Message);
            }

            return awayTeamIDs;
        }

        private void gridbind()
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                conn.Open();

     
                OracleCommand cmd = new OracleCommand(@"
                    SELECT f.FixtureID,f.AwayTeam_ID, at.TeamName, f.Fixture_Time
                    FROM Fixtures f
                    JOIN AwayTeams at ON f.AwayTeam_ID = at.AwayTeam_ID", conn);

                OracleDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                grdTeams.DataSource = dt;
                conn.Close();
            }
        }



        private void grdTeams_SelectionChanged(object sender, EventArgs e)
        {
            if (grdTeams.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = grdTeams.SelectedRows[0];

                // Extract the Fixture_ID from the selected row and set it in the TextBox
                string fixtureID = selectedRow.Cells["FixtureID"].Value.ToString();
                txtFixtureID.Text = fixtureID;


                // Extract the AwayTeam_ID from the selected row
                string awayTeamID = selectedRow.Cells["AwayTeam_ID"].Value.ToString();

                // Set the selected item in the ComboBox
                cobTeamID.SelectedItem = awayTeamID;

                if (DateTime.TryParse(selectedRow.Cells["Fixture_Time"].Value.ToString(), out DateTime fixtureTime))
                {
                    dtpFixture.Value = fixtureTime;
                }
                else
                {
                    // If parsing fails
                    MessageBox.Show("Invalid date format in Fixture_Time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

      private void btnAddTeam_Click(object sender, EventArgs e)
        {

            // Check if a row is selected in the DataGridView
            if (grdTeams.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a fixture to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ensure that the fixture date is in the future
            if (dtpFixture.Value <= DateTime.Now)
            {
                MessageBox.Show("Fixture Date must be in the future", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFixture.Focus();
                return;
            }

            // Check if there is already a fixture on the selected date
            DateTime selectedDate = dtpFixture.Value.Date;
            string query = $"SELECT COUNT(*) FROM Fixtures WHERE Fixture_Time = :selectedDate";

            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("selectedDate", selectedDate));

                conn.Open();
                int fixtureCount = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();

                if (fixtureCount > 0)
                {
                    MessageBox.Show("A fixture is already scheduled for this date!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtpFixture.Focus();
                    return;
                }
            }

            // Get the selected FixtureID from the DataGridView
            DataGridViewRow selectedRow = grdTeams.SelectedRows[0];
            string fixtureID = selectedRow.Cells["FixtureID"].Value.ToString();

            // Get the selected AwayTeam_ID from the ComboBox
            if (cobTeamID.SelectedItem == null)
            {
                MessageBox.Show("Please select a team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string selectedTeamID = cobTeamID.SelectedItem.ToString();

            // Format the Fixture_Time
            string fixtureTime = dtpFixture.Value.ToString("dd-MMM-yy").ToUpper();

           
            Fixtures fixture = new Fixtures(selectedTeamID, fixtureTime);
            fixture.UpdateFixture(fixtureID, selectedTeamID, fixtureTime);

            
            MessageBox.Show("Fixture Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset the UI
            txtFixtureID.Clear();
            cobTeamID.SelectedIndex = -1;
            dtpFixture.Value = DateTime.Now;
            grdTeams.Visible = true;

            // Refresh the DataGridView
            RefreshDataGridView();
        }
        private void RefreshDataGridView()
        {
            // Fetchs the updated data - replace with your actual data
            DataTable updatedData = GetUpdatedData();



            // Binds the updated data to the DataGridView
            grdTeams.DataSource = updatedData;
        }

        private DataTable GetUpdatedData()
        {
            

            string query = @"
                    SELECT f.FixtureID,f.AwayTeam_ID, at.TeamName, f.Fixture_Time
                    FROM Fixtures f
                    JOIN AwayTeams at ON f.AwayTeam_ID = at.AwayTeam_ID";



            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        
    }
}

        