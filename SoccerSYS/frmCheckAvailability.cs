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
    public partial class frmCheckAvailability : Form
    {
        public frmCheckAvailability()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Are you sure you want to Exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
            frmMainMenu to = new frmMainMenu();
            to.Show();
            this.Close();
        }

        private void grpCategory_Enter(object sender, EventArgs e)
        {
            cobMatchDate.Items.Add("09/12/2022");
            cobMatchDate.Items.Add("21/12/2022");
            cobMatchDate.Items.Add("27/12/2022");


            cobTeams.Items.Add("Liverpool v Spurs");
            cobTeams.Items.Add("Man Utd v Chelsea");
            cobTeams.Items.Add("Real Madrid v Barcelona ");
        }

        private void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            if (cobMatchDate.SelectedItem.Equals("09/12/2022") && cobTeams.SelectedItem.Equals("Liverpool v Spurs"))
            {

                MessageBox.Show("Match is not Available anymore", "Availability", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (cobMatchDate.SelectedItem.Equals("21/12/2022") && cobTeams.SelectedItem.Equals("Man Utd v Chelsea"))
            {

                MessageBox.Show("Match is Available", "Availability", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (cobMatchDate.SelectedItem.Equals("27/12/2022") && cobTeams.SelectedItem.Equals("Real Madrid v Barcelona "))
            {

                MessageBox.Show("Match is Available", "Availability", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if ((cobMatchDate.SelectedItem.Equals("21/12/2022") || cobMatchDate.SelectedItem.Equals("27/12/2022")) && cobTeams.SelectedItem.Equals("Liverpool v Spurs") )
            {
                MessageBox.Show("Incorrect Match date", "Availability", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if ((cobMatchDate.SelectedItem.Equals("09/12/2022") || cobMatchDate.SelectedItem.Equals("27/12/2022")) && cobTeams.SelectedItem.Equals("Man Utd v Chelsea"))
            {
                MessageBox.Show("Incorrect Match date", "Availability", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if ((cobMatchDate.SelectedItem.Equals("09/12/2022") || cobMatchDate.SelectedItem.Equals("21/12/2022")) && cobTeams.SelectedItem.Equals("Real Madrid v Barcelona "))
            {
                MessageBox.Show("Incorrect Match date", "Availability", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
