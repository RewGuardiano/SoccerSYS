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
       

        private void btnProcessSalesSubmit_Click(object sender, EventArgs e)
        {


            if (NUDQuantity.Equals("0"))
            {
                MessageBox.Show("Quantity must be greater than zero ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NUDQuantity.Focus();
                return;
            }
            MessageBox.Show("Ticket Processed ", "Sales", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            grdCategory.DataSource = Category.FindCategory(cobTypes.Text).Tables["Cat"];

            if (grdCategory.Rows.Count == 1)
            {
                MessageBox.Show("No Data Found");
                cobTypes.Focus();
                return;
            }

        }

        private void grdCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int TicketID = Convert.ToInt32(grdCategory.Rows[grdCategory.CurrentCell.RowIndex].Cells[0].Value.ToString());

            // aticket = getSale(TicketID);


        

            
        }
    }
}
