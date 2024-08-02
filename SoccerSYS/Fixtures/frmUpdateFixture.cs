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
            

            // Add the event handler for the SelectionChanged event
            grdTeams.SelectionChanged += new EventHandler(grdTeams_SelectionChanged);


            // Load data into the DataGridView when the form loads
            gridbind();
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

                txtTeamID.Text = selectedRow.Cells["AwayTeam_ID"].Value.ToString();
                txtTeamName.Text = selectedRow.Cells["TeamName"].Value.ToString();

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
            if (string.IsNullOrWhiteSpace(txtTeamID.Text))
            {
                MessageBox.Show("Team ID must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTeamID.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(txtTeamName.Text))
            {
                MessageBox.Show("Team Name must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTeamName.Focus();
                return;
            }

            if (dtpFixture.Value <= DateTime.Now)
            {
                MessageBox.Show("Fixture Data must be in the future", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFixture.Focus();
                return;
            }


            string fixtureTime = dtpFixture.Value.ToString("dd-MMM-yy").ToUpper();

            Fixtures fixture = new Fixtures(txtTeamID.Text,fixtureTime);
            fixture.UpdateFixture();
            MessageBox.Show("Fixture Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


            AwayTeam awayteam = new AwayTeam(txtTeamID.Text,txtTeamName.Text);
            awayteam.UpdateFixtureAwayTeams();
            



            //Reset UI
            txtTeamID.Clear();
            txtTeamName.Clear();
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

        