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
    public partial class frmSetCategory : Form
    {
        public frmSetCategory()
        {
            InitializeComponent();
        }

        internal class Show
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMainMenu to = new frmMainMenu();
            to.Show();
            this.Close();
        }

     

        private void btnSetCategory_Click(object sender, EventArgs e)
        {
            if (txtCatCode.Text.Equals(""))
            {
                MessageBox.Show("Category code must be 1 character long", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCatCode.Focus();
                return;

            }

            if (txtdescription.Text.Equals(""))
            {
                MessageBox.Show("Description must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdescription.Focus();
                return;
            }
            bool isNumber = int.TryParse(txtPrice.Text, out int i);
            if (txtPrice.Text.Equals("") && (!txtPrice.Text.Contains('.')) && (isNumber==false))
            {

                MessageBox.Show("Price must be mumeric and a decimal ", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }

            bool numeric = int.TryParse(txtNoSeats.Text, out int j);
            if (txtNoSeats.Text.Equals("") && txtNoSeats.Text.Contains("0") || numeric == false)
            {
                MessageBox.Show("Number of Seats must be numeric and must be greater than 0 ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoSeats.Focus();
                return;
            }
            bool numeric1 = int.TryParse(txtNoSeats.Text, out int k);
            if (txtNoSeatsFrom.Text.Equals("") && txtNoSeatsFrom.Text.Contains("0") || numeric1 == false)
            {
                MessageBox.Show("Number of Seats from must be numeric and must be greater than 0 ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoSeatsFrom.Focus();
                return;

            }
            bool numeric2 = int.TryParse(txtNoSeats.Text, out int l);
            if (txtNoSeatsTo.Text.Equals("") && txtNoSeatsTo.Text.Contains("0") || numeric2 == false)
            {
                MessageBox.Show("Number of Seats to must be numeric and must be greater than 0 ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoSeatsTo.Focus();
                return;

            }
            MessageBox.Show("Category Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);



            txtdescription.Clear();
            txtPrice.Clear();
            txtNoSeats.Clear();
            txtNoSeatsFrom.Clear();
            txtNoSeatsTo.Clear();

      

        }

       
    }
}
