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



            // Add the event handler for the SelectionChanged event
            grdTeams.SelectionChanged += new EventHandler(grdTeams_SelectionChanged);


            // Load data into the DataGridView when the form loads
            gridbind();
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
                // Updated SQL query to join Fixtures and AwayTeams tables

                OracleCommand cmd = new OracleCommand(@"
                    SELECT f.AwayTeam_ID, at.TeamName, f.Fixture_Time
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
                    // Handle the case where parsing fails if necessary
                    MessageBox.Show("Invalid date format in Fixture_Time.");
                }
            }
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            

            if (dtpFixture.Value <= DateTime.Now)
            {
                MessageBox.Show("Fixture Data must be in the future", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFixture.Focus();
                return;
            }

            // Get the selected AwayTeam_ID from the ComboBox
            string selectedTeamID = cobTeamID.SelectedItem.ToString();

            string fixtureTime = dtpFixture.Value.ToString("dd-MMM-yy").ToUpper();

            Fixtures fixture = new Fixtures(selectedTeamID,fixtureTime);
            fixture.UpdateFixture();
            MessageBox.Show("Fixture Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);






            //Reset UI
            cobTeamID.SelectedIndex = -1;
            dtpFixture.Value = DateTime.Now;
            grdTeams.Visible = true;

            // Update DataGridView
            RefreshDataGridView();


        }
        private void RefreshDataGridView()
        {
            // Fetch the updated data - replace with your actual data fetching logic
            DataTable updatedData = GetUpdatedData();



            // Bind the updated data to the DataGridView
            grdTeams.DataSource = updatedData;
        }

        private DataTable GetUpdatedData()
        {
            // Replace with your actual connection string
            
            string query = @"
                    SELECT f.AwayTeam_ID, at.TeamName, f.Fixture_Time
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

        