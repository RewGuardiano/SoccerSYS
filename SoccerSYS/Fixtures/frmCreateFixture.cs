using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SoccerSYS.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Oracle.ManagedDataAccess.Client;

namespace SoccerSYS
{
    public partial class frmCreateFixture : Form
    {
        private Fixtures fixture;
        private static List<AwayTeam> allTeams;
        private static string AwayTeamID;
        public frmCreateFixture()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMainMenu to = new frmMainMenu();
            to.Show();
            this.Close();
        }

        private void btnSubmitSchedule_Click(object sender, EventArgs e)
        {
            if(dtpFixture.Value <= DateTime.Now)
            {
                MessageBox.Show("Fixture Data must be in the future","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFixture.Focus();
                return;
            }
            if(cobAwayTeam.SelectedIndex == -1)
            {
                MessageBox.Show("Away Team ID is blank!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                cobAwayTeam.Focus();
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

            //Save to class
            fixture = new Fixtures(AwayTeamID, dtpFixture.Value.ToString("yyyy-MM-dd"));

            Console.WriteLine(fixture);
            fixture.Createfixture();
            



            MessageBox.Show("Fixture has been Created ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            dtpFixture.Value = DateTime.Now;
            cobAwayTeam.SelectedIndex = -1;

        }

        private void frmCreateFixture_Load(object sender, EventArgs e)
        {
            dtpFixture.Value = DateTime.Now;
            dtpFixture.Format = DateTimePickerFormat.Custom;
            dtpFixture.CustomFormat = "yyyy-MM-dd";
            //load teams into combobox

           

            List<AwayTeam> allTeams = new List<AwayTeam>();
            AwayTeam.viewAllTeams(ref allTeams);

            cobAwayTeam.DisplayMember = "TeamName"; // Set DisplayMember to "TeamName"
            cobAwayTeam.DataSource = allTeams; // Set DataSource to the list of AwayTeam objects
        }

        private void cobAwayTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cobAwayTeam.SelectedIndex != -1)
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                string sqlQuery = $"SELECT AwayTeam_ID FROM AwayTeams WHERE TeamName = '{cobAwayTeam.SelectedItem.ToString()}'";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                conn.Open();


                OracleDataReader dr = cmd.ExecuteReader();


                if (dr.Read())
                {
                    AwayTeamID = dr["AwayTeam_ID"].ToString();

                }
                Console.WriteLine(AwayTeamID);
                dr.Close();
                conn.Close();
            }
        }

        
    }
}
