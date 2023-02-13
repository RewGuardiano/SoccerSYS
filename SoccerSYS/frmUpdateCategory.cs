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
        Category theCategory = new Category();
        public frmUpdateCategory()
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

            theCategory.UpdateCategory();

            txtdescription.Clear();
            txtPrice.Clear();
            txtNoSeats.Clear();
            txtNoSeatsFrom.Clear();
            txtNoSeatsTo.Clear();
            grpCategory.Visible = false;
            grdCategory.Visible = false;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            grdCategory.DataSource = Category.findCategory(txtSearch.Text).Tables["Cat"];

            if(grdCategory.Rows.Count == 1 )
            {
                MessageBox.Show("No Data Found");
                txtSearch.Focus();
                return;
            }
        }

        private void grdCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id = Convert.ToInt32(grdCategory.Rows[grdCategory.CurrentCell.RowIndex].Cells[0].Value.ToString());

            theCategory.getCategory(Id);

            txtdescription.Text = theCategory.getdescription();
            txtPrice.Text = theCategory.getprice().ToString("###0.00");
            txtNoSeats.Text = theCategory.getNoSeats().ToString("00000");
            txtNoSeatsFrom.Text = theCategory.getSeatFrom().ToString("000");
            txtNoSeatsTo.Text = theCategory.getSeatTo().ToString("0000");


            grpCategory.Visible = true;
        }
    }
}
