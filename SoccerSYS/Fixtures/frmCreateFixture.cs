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

namespace SoccerSYS
{
    public partial class frmCreateFixture : Form
    {
        private Fixtures fixture;
        private static List<AwayTeam> allTeams;
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

            /*
            DateTime Fixture_Time = dtpFixture.Value;

            string sqlQuery = "INSERT INTO Fixtures (Away_Team_ID, Fixture_Time) VALUES (" + Fixture_Time.Year + "-" + Fixture_Time.Month + "-" + Fixture_Time.Day + " 22:00:00)";

            MessageBox.Show(Fixture_Time.ToString());
            */

            //Save to class
           // fixture = new Fixtures(dtp)


            //Reset UI
            dtpFixture.Value = DateTime.Now;
            cobAwayTeam.SelectedIndex = -1;

        }

        
        
        

    }
}
