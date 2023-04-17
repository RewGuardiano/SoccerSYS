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
            // Validate form inputs
            if (txtdescription.Text.Equals(""))
            {
                MessageBox.Show("Description must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdescription.Focus();
                return;
            }

            decimal price;
            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Price must be a decimal value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }

            int noSeats, seatFrom, seatTo;
            if (!int.TryParse(txtNoSeats.Text, out noSeats) || noSeats <= 0)
            {
                MessageBox.Show("Number of Seats must be a positive integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoSeats.Focus();
                return;
            }
            if (!int.TryParse(txtNoSeatsFrom.Text, out seatFrom) || seatFrom <= 0)
            {
                MessageBox.Show("Number of Seats from must be a positive integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoSeatsFrom.Focus();
                return;
            }
            if (!int.TryParse(txtNoSeatsTo.Text, out seatTo) || seatTo <= 0)
            {
                MessageBox.Show("Number of Seats to must be a positive integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoSeatsTo.Focus();
                return;
            }
            if (seatTo < seatFrom)
            {
                MessageBox.Show("Number of Seats To must be greater than or equal to Number of Seats from", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoSeatsTo.Focus();
                return;
            }
            theCategory.setCatCode(cobCatCode.Text);
            theCategory.setdescription(txtdescription.Text);
            theCategory.setprice(decimal.Parse(txtPrice.Text));
            theCategory.setNoSeats(int.Parse(txtNoSeats.Text));
            theCategory.setSeatFrom(int.Parse(txtNoSeatsFrom.Text));
            theCategory.setSeatTo(int.Parse(txtNoSeatsTo.Text));

            theCategory.UpdateCategory();
            MessageBox.Show("Category Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            grdCategory.DataSource = Category.FindCategory(txtSearch.Text).Tables["Cat"];

            if(grdCategory.Rows.Count == 1 )
            {
                MessageBox.Show("No Data Found");
                txtSearch.Focus();
                return;
            }
        }

        private void grdCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String CatCode = Convert.ToString(grdCategory.Rows[grdCategory.CurrentCell.RowIndex].Cells[0].Value.ToString());

            theCategory.getCategory(CatCode);


            txtdescription.Text = theCategory.getdescription();
            txtPrice.Text = theCategory.getprice().ToString("###0.00");
            txtNoSeats.Text = theCategory.getNoSeats().ToString("00000");
            txtNoSeatsFrom.Text = theCategory.getSeatFrom().ToString("000");
            txtNoSeatsTo.Text = theCategory.getSeatTo().ToString("0000");


            grpCategory.Visible = true;
        }
        

    }
}
