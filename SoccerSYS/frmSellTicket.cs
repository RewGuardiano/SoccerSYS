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
            int typeId = 0;
            if (!int.TryParse(cobTypes.Text, out typeId))
            {
                MessageBox.Show("Please select a valid type");
                cobTypes.Focus();
                return;
            }

            grdCategory.DataSource = Sale.FindSale(typeId).Tables["Cat"];

            if (grdCategory.Rows.Count == 1)
            {
                MessageBox.Show("No Data Found");
                cobTypes.Focus();
                return;
            }
        }

        private void grdCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ticketId = Convert.ToInt32(grdCategory.Rows[e.RowIndex].Cells[0].Value);

            Sale.getSale(ticketId);
        }
    }

    
    }
// This function along with the Fixture function would help us acculate the Revenue and Category ticket analysis which couldn't finish//
