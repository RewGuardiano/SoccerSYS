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
    public partial class frmUpdateCategory : Form
    {
        public frmUpdateCategory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMainMenu to = new frmMainMenu();
            to.Show();
            this.Close();
        }

        private void grpCategory_Enter(object sender, EventArgs e)
        {

        }
        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if (txtdescription.Text.Equals(""))
            {
                MessageBox.Show("Description must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdescription.Focus();
                return;
            }
            bool isNumber = int.TryParse(txtPrice.Text, out int i);
            if (txtPrice.Text.Equals("") && (!txtPrice.Text.Contains('.')) && (isNumber == false))
            {

                MessageBox.Show("Price must be mumeric and a decimal ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            MessageBox.Show("Category Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);



            txtdescription.Clear();
            txtPrice.Clear();
            txtNoSeats.Clear();
         
        }
    }
}
