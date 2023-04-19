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
       Category theCategory = new Category();
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

            DialogResult dialog = MessageBox.Show("Are you sure you want to remove?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                theCategory.setCatCode(cobCatCode.Text);
                theCategory.RemoveCategory();
                MessageBox.Show("Category Status to Unavailable", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                this.Close();

                frmMainMenu to = new frmMainMenu();
                to.Show();
            }
      
        }


        private void btnSearchRemove_Click(object sender, EventArgs e)
        {
            grdCategoryRemove.DataSource = Category.FindCategory(txtSearchRemove.Text).Tables["Cat"];

            if (grdCategoryRemove.Rows.Count == 1)
            {
                MessageBox.Show("No Data Found");
                txtSearchRemove.Focus();
                return;
            }
        }

        private void grdCategoryRemove_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String CatCode = Convert.ToString(grdCategoryRemove.Rows[grdCategoryRemove.CurrentCell.RowIndex].Cells[0].Value.ToString());

            theCategory.getCategory(CatCode);


          
        }
    }
}
