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

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        internal class Show
        {
           
        }

       

        private void frmSetCategory_Load(object sender, EventArgs e)
        {
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMainMenu to = new frmMainMenu();
            to.Show();
            this.Close();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCatCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSetCategory_Click(object sender, EventArgs e)
        {
     
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
