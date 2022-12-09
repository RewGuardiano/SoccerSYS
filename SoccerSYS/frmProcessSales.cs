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
    public partial class frmProcessSales : Form
    {
        public frmProcessSales()
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
            bool IsNumber = int.TryParse(txtTotalPrice.Text, out int i);
            if ( IsNumber== false || txtTotalPrice.Text.Equals("0"))
            {
                MessageBox.Show("Total Price must be numeric and greater than zero ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTotalPrice.Focus();
                return;
            }
            bool IsNumeric = int.TryParse(txtQty.Text, out int j);
            if(IsNumeric==false || txtQty.Text.Equals("0"))
            {
                MessageBox.Show("Quantity must be numeric and greater than zero ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQty.Focus();
                return;
            }
            MessageBox.Show("Sales Processed ", "Sales", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
