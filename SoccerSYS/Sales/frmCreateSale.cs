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

        private void btnCreateSale_Click(object sender, EventArgs e)
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
       
            if (NUDQuantity.Value > Categories.getAvailableSeats(CobCatCodes.SelectedItem.ToString().Substring(0,1)))
            {
                MessageBox.Show("Quantity is more that Available Seats in the Category ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CobCatCodes.SelectedIndex = -1;
                return;
            }
            

            decimal Price = Categories.getCategoryPrice(CobCatCodes.SelectedItem.ToString().Substring(0, 1))*NUDQuantity.Value;
            dgvCart.Rows.Add(CobCatCodes.SelectedItem.ToString().Substring(0, 1), NUDQuantity.Value, Price, cobFixtures.SelectedItem.ToString().Substring(0, 1));
                total_price += Price;
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

            }

            //Confirmation message
            MessageBox.Show("Succesfully Made a Sale", "Sales", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}

    
    

