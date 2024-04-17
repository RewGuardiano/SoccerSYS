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
    public partial class frmCreateSale : Form
    {
        
        public frmCreateSale()
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
        /*
        private void btnConfirm_Click(object sender, EventArgs e)
        {
          



            MessageBox.Show("Sale Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       

        private void btnSearchSale_Click(object sender, EventArgs e)
        {
            GrdSale.DataSource = Categories.FindCategory(txtTicketIDSale.Text).Tables["Cat"];

            if (GrdSale.Rows.Count == 1)
            {
                MessageBox.Show("No Data Found");
                txtTicketIDSale.Focus();
                return;
            }

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string sqlQuery = "SELECT * FROM CATEGORYS WHERE CatCode = :catCode"; // Use parameterized query

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.Parameters.Add(new OracleParameter("catCode", txtTicketIDSale.Text)); // Add parameter

          

            conn.Close();
        }

        private void GrdSale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        */
    }
}

    
    
// This function along with the Fixture function would help us acculate the Revenue and Category ticket analysis which couldn't finish//
