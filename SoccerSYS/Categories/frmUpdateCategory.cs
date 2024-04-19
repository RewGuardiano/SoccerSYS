using Oracle.ManagedDataAccess.Client;
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

        }






        /*

                private void btnUpdateCategory_Click(object sender, EventArgs e)
                {
                    // Validate form inputs
                    if (txtdescription.Text.Equals(""))
                    {
                        MessageBox.Show("Description must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtdescription.Focus();
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

                    grpCategory.Visible = false;
                    grdCategory.Visible = false;

                }

                private void btnSearch_Click(object sender, EventArgs e)
                {
                    grdCategory.DataSource = Categories.FindCategory(txtSearch.Text).Tables["Cat"];

                    if (grdCategory.Rows.Count == 1)
                    {
                        MessageBox.Show("No Data Found");
                        txtSearch.Focus();
                        return;
                    }

                    OracleConnection conn = new OracleConnection(DBConnect.oradb);
                    conn.Open();

                    string sqlQuery = "SELECT * FROM CATEGORYS WHERE CatCode = :catCode"; // Use parameterized query

                    OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                    cmd.Parameters.Add(new OracleParameter("catCode", txtSearch.Text)); // Add parameter

                    OracleDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {

                        MessageBox.Show("Please Re-type the data","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtdescription.Text = dr.GetString(2);
                        txtPrice.Text = dr.GetDecimal(3).ToString();

                    }
                    else
                    {
                        MessageBox.Show("No data found! ");
                    }

                    conn.Close();
                }


                private void grdCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
                {
                    String CatCode = Convert.ToString(grdCategory.Rows[grdCategory.CurrentCell.RowIndex].Cells[0].Value.ToString());

                    theCategory.getCategory(CatCode);


                    txtdescription.Text = theCategory.getdescription();
                    txtPrice.Text = theCategory.getprice().ToString("###0.00");



                    grpCategory.Visible = true;
                }
                */

    }
}
