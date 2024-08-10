using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Oracle.ManagedDataAccess.Client;


namespace SoccerSYS
{
    public partial class frmCreateCategory : Form
    {
        private static new Form Parent;

        public frmCreateCategory(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMainMenu to = new frmMainMenu();
            to.Show();
            this.Close();
            Parent.Visible = true;
        }

        private void frmCreateCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Visible = true;
        }

        private void btnSetCategory_Click_1(object sender, EventArgs e)
        {
            try
            {
                string catCode = txtCatCode.Text.Trim(); // Get the category code

                // Validate CatCode format and uniqueness
                if (!string.IsNullOrEmpty(catCode))
                {
                    if (Regex.IsMatch(catCode, "^[A-Z]+$"))
                    {
                        // Check if the CatCode already exists in the database
                        if (CheckIfCatCodeExists(catCode))
                        {
                            MessageBox.Show("Category code already exists. Please enter a unique CatCode.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Category code must only contain uppercase letters.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Category code must not be empty.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate other form inputs
                if (string.IsNullOrEmpty(txtdescription.Text))
                {
                    MessageBox.Show("Description must be entered.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtdescription.Focus();
                    return;
                }
                if (Categories.ValidateMaxSeatsLimit()==false)
                {
                    

                }
                else
                {
                    MessageBox.Show("Cannot create more categories. Maximum seats limit (" + Categories.maxSeatsLimit + ") reached.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create the category if all validations pass
                Categories category = new Categories(txtCatCode.Text, txtdescription.Text, NUDCategoriesPrice.Value, Convert.ToInt32(NUDCategorySeats.Value));
                category.createCategory();

                MessageBox.Show("Category has been created successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear input fields
                txtCatCode.Clear();
                txtdescription.Clear();
                txtCatCode.Focus();
                NUDCategoriesPrice.Value = NUDCategoriesPrice.Minimum;
                NUDCategorySeats.Value = NUDCategorySeats.Minimum;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool CheckIfCatCodeExists(string catCode)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM CATEGORIES WHERE CATCODE = :CatCode";

                OracleCommand command = new OracleCommand(query, conn);
                command.Parameters.Add(":CatCode", catCode.ToUpper());

                int count = Convert.ToInt32(command.ExecuteScalar());

                conn.Close();

                return count > 0;
            }
        }

      
    }
}


           
       
    


       
    

       
    
