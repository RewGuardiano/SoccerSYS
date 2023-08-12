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
    public partial class frmAddTeam : Form
    {
  

        public frmAddTeam()
        {
            InitializeComponent();
        }

        private void btnBackbutton_Click(object sender, EventArgs e)
        {
            frmMainMenu to = new frmMainMenu();
            to.Show();
            this.Close();
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            
            if(txtTeamID.Text.Equals(""))
            {
                MessageBox.Show("A TeamID must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTeamID.Focus();
                return;
            }
            if (txtTeamName.Text.Equals(""))
            {
                MessageBox.Show("A Team Name must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTeamName.Focus();
                return;
            }

           // Team ATeam = new Team(TeamID, TeamName);

            //ATeam.AddTeam();

            MessageBox.Show("Team Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
