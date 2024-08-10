using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Oracle.ManagedDataAccess.Client;
using SoccerSYS.Classes;

namespace SoccerSYS
{
    public partial class frmCreateSale : Form
    {
        private static List<string> allCategoryCodes = new List<string>();
        private static List<string> allfixtureDetails = new List<string>();
        private static decimal total_price = 0; 
        public frmCreateSale()
        {
            InitializeComponent();
        }

        private void btnCreateSaleBack_Click(object sender, EventArgs e)
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




        public bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void btnConfirmEmail_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Then, check if the email is in a valid format
            if (!IsValid(txtEmail.Text))
            {
                MessageBox.Show("Email invalid, Must be email format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Clear();
                return;
            }

            // If both checks pass, make the group box visible
            gpbCatCode.Visible = true;
        }

        private void frmCreateSale_Load(object sender, EventArgs e)
        {
            //Load Match details into combobox
            Fixtures.getFixtureDetails(ref allfixtureDetails);
            foreach (string fixtureID in allfixtureDetails)
            {
                cobFixtures.Items.Add(FixtureID);


            }

            cobFixtures.DisplayMember = "FixtureID"; // Set DisplayMember to "TeamName"
            cobFixtures.DataSource = allfixtureDetails; // Set DataSource to the list of AwayTeam objects


            Categories.getCategoryDetails(ref allCategoryCodes);

            foreach (string category in allCategoryCodes)
            {

                CobCatCodes.Items.Add(category);
            }
           

        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Ensure a category is selected
            if (CobCatCodes.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ensure a category is selected
            if (CobCatCodes.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Get the selected fixture ID
            int fixtureID = int.Parse(cobFixtures.SelectedItem.ToString().Substring(0, 1));

            // Get the selected category code and quantity
            string selectedCatCode = CobCatCodes.SelectedItem.ToString().Substring(0, 1);
            int selectedQuantity = (int)NUDQuantity.Value;

            // Check if there are enough available seats for the selected category and fixture
            int availableSeats = FixtureSeats.GetAvailableSeats(selectedCatCode, fixtureID);
            if (selectedQuantity > availableSeats)
            {
                MessageBox.Show($"Quantity exceeds available seats. Only {availableSeats} seats are available for this category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NUDQuantity.Value = 0; // Reset quantity to 0
                return;
            }
            
            

            // Proceed with adding the sale item to the cart
            decimal price = Categories.getCategoryPrice(selectedCatCode) * selectedQuantity;
            dgvCart.Rows.Add(selectedCatCode, selectedQuantity, price, cobFixtures.SelectedItem.ToString().Substring(0, 1));
            total_price += price;
            txtTotPrice.Text = total_price.ToString();

            grpBoxCart.Visible = true;
            CobCatCodes.SelectedIndex = -1;
            NUDQuantity.Value = 0;

            btnConfirmEmail.Enabled = false;
            txtEmail.Enabled = false;
            cobFixtures.Enabled = false;


        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            string dateTime = DateTime.Now.ToString("yyyy-MM-dd");
            int fixtureID = int.Parse(cobFixtures.SelectedItem.ToString().Substring(0,1));
            int Sub_total = int.Parse(txtTotPrice.Text.ToString());
           //Save to class
           Sale sale = new Sale(txtEmail.Text.ToString(),fixtureID, dateTime,Sub_total,'N');
            //Save to database
            sale.addSale();
            /*
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                string[] seatNums = row.Cells["seatNum"].Value.ToString().Split(',');
                int[] seatNumArr = Array.ConvertAll(seatNums, s => int.Parse(s));
                for (int i = 0; i < seatNumArr.Length; i++)
                {
                    //Create sale seat objects and saves to database
                    SaleSeat saleSeat = new SaleSeat(sale.SalesID, seatNumArr[i]);
                    saleSeat.addSaleSeat();
                    //Update status for matchSeats to 'O' as its occupied
                    MatchSeat.updateSeatStatus(sale.MatchID, seatNumArr[i]);
                }*/
            foreach(DataGridViewRow row in dgvCart.Rows)
            {
                string catcode = row.Cells["CatCode"].Value.ToString();
                int quantity = int.Parse(row.Cells["Quantity"].Value.ToString());
                int price = int.Parse(row.Cells["Price"].Value.ToString());

                SaleItem saleItem = new SaleItem(sale.GetSaleID(), catcode, quantity, price);
                saleItem.addSaleItem();

                // Update available seats in the FixtureSeats table
                int currentAvailableSeats = FixtureSeats.GetAvailableSeats(catcode, fixtureID);
                if (quantity > currentAvailableSeats)
                {
                    MessageBox.Show("Error: Quantity exceeds available seats. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int newAvailableSeats = currentAvailableSeats - quantity;
                FixtureSeats.UpdateAvailableSeats(catcode, fixtureID, newAvailableSeats);

            }


            //Confirmation message
            MessageBox.Show("Succesfully Made a Sale", "Sales", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ResetForm();
        }

        private void ResetForm()
        {
            // Clear all fields and reset controls
            
            cobFixtures.SelectedIndex = -1;
            cobFixtures.Enabled = true;
            CobCatCodes.SelectedIndex = -1;
            NUDQuantity.Value = 0;
            txtTotPrice.Clear();
            dgvCart.Rows.Clear();
            total_price = 0;

            // Hide group boxes
            gpbCatCode.Visible = false;
            grpBoxCart.Visible = false;

            // Enable the email field and confirm email button
            txtEmail.Enabled = true;
            btnConfirmEmail.Enabled = true;
        }


    }
}

    
    

