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
    public partial class frmScheduleMatch : Form
    {
        public frmScheduleMatch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMainMenu to = new frmMainMenu();
            to.Show();
            this.Close();
        }


        
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

        private void grpCategory_Enter(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("Teams.txt");
            cobTeams1.Items.AddRange(lines);

            string[] lines2 = File.ReadAllLines("Teams.txt");
            cobTeams2.Items.AddRange(lines2);

        }

        //Didn't get to finish Function. In schedule match it would allow you to the manager to pick a team from a reference file Teams.txt and Record the tickets sold after a Ticket was 
        //from the Sales Table which would allow the manage the SeatAvailability
    }
}
