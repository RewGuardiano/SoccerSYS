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


namespace SoccerSYS
{
    public partial class frmCreateCategory : Form
    {

        public frmCreateCategory()
        {
            InitializeComponent();
        }

        internal class Show
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMainMenu to = new frmMainMenu();
            to.Show();
            this.Close();
        }

        private void btnSetCategory_Click_1(object sender, EventArgs e)
        {
            // try to validate so there are no duplicate Category Codes//
            try
            {
                string catCode = txtCatCode.Text.Trim(); // Get the category code
                //write validation to not allow number sybmbol and must be uppercase. 
                // Check if the category code already exists in the database
                if (!string.IsNullOrEmpty(catCode))
                {
                    // Check if the category code contains only uppercase letters
                    if (Regex.IsMatch(catCode, "^[A-Z]+$"))
                    {
                       
                    }
                    else
                    {
                        MessageBox.Show("Category code must not be special characters,  only uppercase letters.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Handle the case where the category code is not in uppercase
                    }
                }
                else
                {
                    MessageBox.Show("Must not be Empty.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Validate form inputs
                if (txtdescription.Text.Equals(""))
                {
                    MessageBox.Show("Description must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtdescription.Focus();
                    return;
                }

                
            } 













            /*
            Categories ticketIDCat = new Categories();
            int ticketId = ticketIDCat.setTicketID();

            Categories aCategory = new Category(ticketId, txtCatCode.Text, txtdescription.Text, Convert.ToDecimal(txtPrice.Text), Convert.ToInt32(txtNoSeats.Text));
            ;

            Console.WriteLine(aCategory.getTicketID());


            aCategory.SetCategory();


            MessageBox.Show("Category Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
            */

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}


           
       
    


       
    

       
    
