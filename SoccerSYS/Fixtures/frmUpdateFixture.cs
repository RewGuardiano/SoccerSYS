using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        

        /*
private void btnSearchTeam_Click(object sender, EventArgs e)
{
grdTeams.DataSource = Team.FindTeams(txtEnterTeamID.Text).Tables["TeamID"];

if (grdTeams.Rows.Count == 1)
{
MessageBox.Show("No Data Found");
txtEnterTeamID.Focus();
return;
}

OracleConnection conn = new OracleConnection(DBConnect.oradb);
conn.Open();

string sqlQuery = "SELECT * FROM Teams WHERE TeamID = :TeamID"; // Use parameterized query

OracleCommand cmd = new OracleCommand(sqlQuery, conn);
cmd.Parameters.Add(new OracleParameter("TeamID", txtEnterTeamID.Text)); // Add parameter

OracleDataReader dr = cmd.ExecuteReader();
if (dr.Read())
{

MessageBox.Show("Please Re-type the data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
txtTeamID.Text = dr.GetString(1);
txtTeamName.Text = dr.GetString(3);

}
else
{
MessageBox.Show("No data found! ");
}

conn.Close();
}
private void grdTeams_CellContentClick(object sender, DataGridViewCellEventArgs e)
{
String TeamID = Convert.ToString(grdTeams.Rows[grdTeams.CurrentCell.RowIndex].Cells[0].Value.ToString());

NewTeam.getTeams(TeamID);


txtTeamID.Text = NewTeam.getTeamID();
txtTeamName.Text = NewTeam.getTeamName();


grpTeams.Visible = true;
}

}
*/
    }
}

        