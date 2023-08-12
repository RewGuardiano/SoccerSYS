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

    


        private void mbuManageCategories_Click(object sender, EventArgs e)
        {

        }

        private void mbuUpdateCategory_Click(object sender, EventArgs e)
        {
            frmUpdateCategory to = new frmUpdateCategory();
            to.Show();
            this.Hide();
        }

        private void scheduleMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScheduleMatch to = new frmScheduleMatch();
            to.Show();
            this.Hide();
        }

        private void cancelMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCancelMatch to = new frmCancelMatch();
            to.Show();
            this.Hide();
        }

       

        private void sellTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSellTicket to = new frmSellTicket();
            to.Show();
            this.Hide();

        }

        private void yearlyRevenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frrmYearlyRevenueAnalysis to = new frrmYearlyRevenueAnalysis();
            to.Show();
            this.Hide();
        }

        private void yearlyTicketRevenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYearlyTicketAnalysis to = new frmYearlyTicketAnalysis();
            to.Show();
            this.Hide();
        }

        private void removeCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemoveCategory to = new frmRemoveCategory();
            to.Show();
            this.Hide();
        }

        private void mbaAddTeam_Click(object sender, EventArgs e)
        {
            frmAddTeam to = new frmAddTeam();
            to.Show();
            this.Hide();
        }

        private void mbaUpdateTeam_Click(object sender, EventArgs e)
        {
            frmUpdateCategory to = new frmUpdateCategory();
            to.Show();
            this.Hide();
        }
    }
}
