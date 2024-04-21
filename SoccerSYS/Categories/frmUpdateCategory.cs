﻿using Oracle.ManagedDataAccess.Client;
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
    
        private Categories Category;
        private List<string> allCategories;
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

        
        private void cobCatCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cobCatCode.SelectedIndex != -1)
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                string sqlQuery = $"SELECT Description,Price,MaxSeats FROM Categories WHERE CatCode = '{cobCatCode.SelectedItem.ToString().Substring(0, 1)}'";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                conn.Open();


                OracleDataReader dr = cmd.ExecuteReader();
                

                if (dr.Read())
                {
                    txtdescription.Text = dr["Description"].ToString();
                    NUDCategoriesPrice.Text = dr["Price"].ToString();
                    NUDCategorySeats.Text = dr["MaxSeats"].ToString();
                }
                dr.Close();
                conn.Close();
            }
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
            if (Categories.ValidateMaxSeatsLimit() == false)
            {


            }
            else
            {
                MessageBox.Show("Cannot create more categories. Maximum seats limit (" + Categories.maxSeatsLimit + ") reached.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }




            Category = new Categories(cobCatCode.SelectedItem.ToString().Substring(0,1),txtdescription.Text,NUDCategoriesPrice.Value,Convert.ToInt32(NUDCategorySeats.Value));
            Category.updateCategory();
            MessageBox.Show("Category Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

         


            //Reset UI
            cobCatCode.SelectedIndex = -1;
            txtdescription.Clear();
            grpCategory.Visible = false;
            cobCatCode.Focus();
        }

        

        private void frmUpdateCategory_Load(object sender, EventArgs e)
        {
            Categories.getCategoryDetails(ref allCategories);

            foreach(string category in allCategories)
            {

                cobCatCode.Items.Add(category);
            }

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


                    Categories theCategory = new Categories();

                    theCategory.setCatCode(cobCatCode.Text);
                    theCategory.setdescription(txtdescription.Text);
                    theCategory.setprice(decimal.Parse(NUDCategoriesPrice.Text));


                    theCategory.UpdateCategory();
                    MessageBox.Show("Category Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtdescription.Clear();
                    

                    grpCategory.Visible = false;
                    grdCategory.Visible = false;

                }

                


                private void grdCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
                {
                    String CatCode = Convert.ToString(grdCategory.Rows[grdCategory.CurrentCell.RowIndex].Cells[0].Value.ToString());

                    theCategory.getCategory(CatCode);


                    txtdescription.Text = theCategory.getdescription();
                    


                    grpCategory.Visible = true;
                }
                */

    }
}
