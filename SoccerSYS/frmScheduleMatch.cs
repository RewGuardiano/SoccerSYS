using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (txtTeams.Text.Equals(""))
            {
                MessageBox.Show("Teams textbox must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTeams.Focus();
                return;
            }
            if (!txtMatchTime.TextLength.Equals(5))
            {
                MessageBox.Show("Match time must be entered and has 5 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatchTime.Focus();
                return;
            }
            DateTime date;
            bool isValidDate = DateTime.TryParse(txtMatchDate.Text,out date );

            if(isValidDate == false)
            {
                MessageBox.Show("Match Date must be entered and is in date type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatchDate.Focus();
                return;
            }
            MessageBox.Show("Match Scheduled", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);



            txtMatchID.Clear();
            txtTeams.Clear();
            txtMatchTime.Clear();
            txtMatchDate.Clear();
           
        }
    }
}
