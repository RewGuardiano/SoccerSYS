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
                // Validate the MaxSeats limit with existing categories
                int newMaxSeats = Convert.ToInt32(NUDCategorySeats.Value);
                int currentTotalMaxSeats = GetTotalMaxSeats();

                if (currentTotalMaxSeats + newMaxSeats > 500)
                {
                    MessageBox.Show("Adding this category will exceed the maximum allowed seats of 500.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private int GetTotalMaxSeats()
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                conn.Open();

                // Query to sum the MaxSeats of all existing categories
                string query = "SELECT SUM(MaxSeats) FROM CATEGORIES";

                OracleCommand command = new OracleCommand(query, conn);

                object result = command.ExecuteScalar();

                conn.Close();

                // If no categories exist, return 0, otherwise return the total MaxSeats
                return result == DBNull.Value ? 0 : Convert.ToInt32(result);
            }
        }

    }
}


           
       
    


       
    

       
    
