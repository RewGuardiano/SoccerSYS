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
    public partial class frmCancelMatch : Form
    {
        public frmCancelMatch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMainMenu to = new frmMainMenu();
            to.Show();
            this.Close();
        }

        private void grpCategory_Enter(object sender, EventArgs e)
        {
            cobMatchID.Items.Add("578");
            cobMatchID.Items.Add("678");
            cobMatchID.Items.Add("245");

            cobTeams.Items.Add("Liverpool v Spurs");
            cobTeams.Items.Add("Man Utd v Chelsea");
            cobTeams.Items.Add("Real Madrid v Barcelona ");
        }
    }
}
