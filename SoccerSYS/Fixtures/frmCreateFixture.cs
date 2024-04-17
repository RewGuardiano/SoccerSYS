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

namespace SoccerSYS
{
    public partial class frmCreateFixture : Form
    {
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
            DateTime Fixture_Time = dtpFixture.Value;

            string sqlQuery = "INSERT INTO Fixtures (Away_Team_ID, Fixture_Time) VALUES (" + Fixture_Time.Year + "-" + Fixture_Time.Month + "-" + Fixture_Time.Day + " 22:00:00)";

            MessageBox.Show(Fixture_Time.ToString());
        }

        /*
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {


            bool isNumber = int.TryParse(txtMatchID.Text, out int i);
            if ( isNumber == false)
            {
                MessageBox.Show("MatchID must be mumeric ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatchID.Focus();
                return;
            }
            if (cobTeams1.Text.Equals(""))
            {
                MessageBox.Show("Team 1 textbox must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cobTeams1.Focus();
                return;
            }
            if (cobTeams2.Text.Equals(""))
            {
                MessageBox.Show("Team 2 textbox must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cobTeams2.Focus();
                return;
            }
            if (!txtMatchTime.TextLength.Equals(5))
            {
                MessageBox.Show("Match time must be entered and has 5 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatchTime.Focus();
                return;
            }

          
            MessageBox.Show("Match Scheduled", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


             
            txtMatchID.Clear();
            txtMatchTime.Clear();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        /*
private void grpCategory_Enter(object sender, EventArgs e)
{
   // Assuming you have a List of Team objects named 'teams' in your 'table' class.
   List<Team> teams = Team.GetTeams();

   // Clear existing items before adding new ones
   cobTeams1.Items.Clear();
   cobTeams2.Items.Clear();

   foreach (Team team in teams)
   {
       cobTeams1.Items.Add(team.TeamName);
       cobTeams2.Items.Add(team.TeamName);
   }

}

        //Didn't get to finish Function. In schedule match it would allow you to the manager to pick a team from a reference file Teams.txt and Record the tickets sold after a Ticket was 
        //from the Sales Table which would allow the manage the SeatAvailability
    }*/
    }
}
