using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace SoccerSYS
{
    public partial class frmSellTicket : Form
    {
        Sale aticket = new Sale();
        public frmSellTicket()
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }
    }

    
    }
// This function along with the Fixture function would help us acculate the Revenue and Category ticket analysis which couldn't finish//
