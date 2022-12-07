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
    public partial class frmRemoveCategory : Form
    {
        public frmRemoveCategory()
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

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {

            if (cobRemoveDescription.Text.Equals(""))
            {
                MessageBox.Show("Description must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }

            if (cobRemovePrice.Text.Equals(""))
            {

                MessageBox.Show("Price must be mumeric and a decimal ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
            }
            if (cobRemoveSeats.Text.Equals(""))
            {
                MessageBox.Show("Number of Seats must be numeric and must be greater than 0 ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            MessageBox.Show("Category Removed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

       
    }
}
