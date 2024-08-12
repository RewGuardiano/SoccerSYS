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
            if (Categories.ValidateMaxSeatsLimit())
            {
                MessageBox.Show("Cannot create more categories. Maximum seats limit reached.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method without proceeding to create a new category
            }


            frmCreateCategory to = new frmCreateCategory(this);
            to.Show();
            this.Hide();
          
        }

        private void mbuManageCategories_Click(object sender, EventArgs e)
        {

        }

        private void mbuUpdateCategory_Click(object sender, EventArgs e)
        {
            frmUpdateCategory to = new frmUpdateCategory(this);
            to.Show();
            this.Hide();
        }

        private void scheduleMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateFixture to = new frmCreateFixture(this);
            to.Show();
            this.Hide();
        }

        private void cancelMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateFixture to = new frmUpdateFixture(this);
            to.Show();
            this.Hide();
        }

       

        private void sellTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateSale to = new frmCreateSale(this);
            to.Show();
            this.Hide();

        }

        private void yearlyRevenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frrmYearlyRevenueAnalysis to = new frrmYearlyRevenueAnalysis(this);
            to.Show();
            this.Hide();
        }

        private void yearlyTicketRevenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYearlyTicketAnalysis to = new frmYearlyTicketAnalysis(this);
            to.Show();
            this.Hide();
        }

       

        

        private void mbaUpdateTeam_Click(object sender, EventArgs e)
        {
            frmUpdateCategory to = new frmUpdateCategory(this);
            to.Show();
            this.Hide();
        }

        private void removeSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemoveSale to = new frmRemoveSale(this);
            to.Show();
            this.Hide();
        }

     
    }
}
