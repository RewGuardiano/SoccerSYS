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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void viewStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void performAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void setCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSetCategory to = new frmSetCategory();
            to.Show();
            this.Hide();
        }

        private void mbuProcessSales_Click(object sender, EventArgs e)
        {

        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
