using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace SoccerSYS
{
    public partial class frmRemoveSale : Form
    {
        private static new Form Parent;
        public frmRemoveSale(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void btnRemoveSales_Click(object sender, EventArgs e)
        {
            
            this.Close();
            Parent.Visible = true;
        }

        private void frmRemoveSale_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Visible = true;
        }

        private void frmRemoveSale_Load(object sender, EventArgs e)
        {
            // Populate the DataGridView with Sale data
            LoadSalesData();
        }

        private void LoadSalesData()
        {
            try
            {
                // Define the connection string and the query
                using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
                {
                    string query = @"
                    SELECT 
                        S.SaleID, 
                        S.Email, 
                        S.Sale_Time, 
                        S.Sub_Total, 
                        S.FixtureID,
                        S.Cancel_Sale,
                        SI.SaleItem_ID, 
                        SI.CatCode, 
                        SI.Quantity, 
                        SI.Total_Price
                    FROM Sales S
                    JOIN SaleItems SI ON S.SaleID = SI.SaleID
                    WHERE S.Cancel_Sale<> 'Y'";  // Exclude canceled sales

                    // Set up the data adapter and fill the DataTable
                    OracleDataAdapter da = new OracleDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Clear existing columns and add a new button column
                    grdSales.Columns.Clear();

                    // Add button column for details
                    DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn
                    {
                        HeaderText = "View Details",
                        Name = "btnViewDetails",
                        Text = "View",
                        UseColumnTextForButtonValue = true
                    };
                    grdSales.Columns.Add(btnColumn);

                    // Bind the DataTable to the DataGridView
                    grdSales.DataSource = dt;

                    // Set column headers
                    grdSales.Columns["SaleID"].HeaderText = "Sale ID";
                    grdSales.Columns["Email"].HeaderText = "Customer Email";
                    grdSales.Columns["Sale_Time"].HeaderText = "Sale Time";
                    grdSales.Columns["Sub_Total"].HeaderText = "Sub Total";
                    grdSales.Columns["FixtureID"].HeaderText = "Fixture ID";
                    grdSales.Columns["Cancel_Sale"].HeaderText = "Cancelled Sale";
                    grdSales.Columns["SaleItem_ID"].HeaderText = "Sale Item ID";
                    grdSales.Columns["CatCode"].HeaderText = "Category Code";
                    grdSales.Columns["Quantity"].HeaderText = "Quantity";
                    grdSales.Columns["Total_Price"].HeaderText = "Total Price";

                    // Hide specific columns
                    grdSales.Columns["SaleItem_ID"].Visible = false;
                    grdSales.Columns["Total_Price"].Visible = false;
                    grdSales.Columns["Cancel_Sale"].Visible = false;

                    // Attach event handler for button clicks
                    grdSales.CellContentClick += grdSales_CellContentClick;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void grdSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the button column and row index are valid
            if (e.ColumnIndex == grdSales.Columns["btnViewDetails"].Index && e.RowIndex >= 0)
            {
                // Make the sale details group box visible
                grpSaleDetails.Visible = true;

                // Display selected row's details in the respective textboxes and date time picker
                txtSaleID.Text = grdSales.Rows[e.RowIndex].Cells["SaleID"].Value.ToString();
                txtEmail.Text = grdSales.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                dtPickSalesDate.Text = grdSales.Rows[e.RowIndex].Cells["Sale_Time"].Value.ToString();
                txtTotSales.Text = $"€{Convert.ToDecimal(grdSales.Rows[e.RowIndex].Cells["Sub_Total"].Value)}";
                txtMatchID.Text = grdSales.Rows[e.RowIndex].Cells["FixtureID"].Value.ToString();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // Validate and parse SaleID
            string saleIDText = txtSaleID.Text;
            if (int.TryParse(saleIDText, out int saleID))
            {
                // Create a Sale object to update the Cancel_Sale field
                Sale saleToUpdate = new Sale(
                    txtEmail.Text,
                    Convert.ToInt32(txtMatchID.Text),
                    dtPickSalesDate.Value.ToString("yyyy-MM-dd"),
                    Convert.ToInt32(txtTotSales.Text.Substring(1)),
                    'Y'  // Set Cancel_Sale to 'Y' for cancellation
                );

                // Set the SaleID of the Sale object to update
                saleToUpdate.SetSaleID(saleID);

                // Ask user if they really want to return the sale
                DialogResult dialogResult = MessageBox.Show($"Are you sure you want to return Sale ID: {txtSaleID.Text}?","Return Sale",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        // Update the sale status to canceled in the Sales table
                        UpdateSaleStatus(saleToUpdate);

                        // Confirmation message
                        MessageBox.Show($"Successfully returned Sale ID: {txtSaleID.Text}","Return Sale",MessageBoxButtons.OK,MessageBoxIcon.Information);

                        // Get the CatCode for the given FixtureID                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
                        string catCode = GetCatCodeForFixture(Convert.ToInt32(txtMatchID.Text));

                        if (catCode != null)
                        {
                            // Fetch the current number of available seats
                            int currentAvailableSeats = FixtureSeats.GetAvailableSeats(catCode, Convert.ToInt32(txtMatchID.Text));

                            // Increment available seats based on the sale information
                            int seatsToReturn = GetSeatsCountFromSale(Convert.ToInt32(txtSaleID.Text));
                            int newAvailableSeats = currentAvailableSeats + seatsToReturn;

                            // Update available seats in the FixtureSeats table
                            FixtureSeats.UpdateAvailableSeats(catCode, Convert.ToInt32(txtMatchID.Text), newAvailableSeats);
                        }
                        else
                        {
                            MessageBox.Show("Category code for the fixture not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        // Remove the row from DataGridView
                        grdSales.Rows.Remove(grdSales.CurrentRow);

                        // Reset UI
                        TextBox[] txtBoxes = { txtSaleID, txtEmail, txtTotSales, txtMatchID };
                        foreach (TextBox textBox in txtBoxes)
                        {
                            textBox.Clear();
                        }
                        grpSaleDetails.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Sale ID format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method to get the number of seats related to the sale
        private int GetSeatsCountFromSale(int saleID)
        {
            int seatsCount = 0;
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                string sqlQuery = "SELECT SUM(Quantity) FROM SaleItems WHERE SaleID = :SaleID";
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(new OracleParameter(":SaleID", saleID));
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    seatsCount = result != null ? Convert.ToInt32(result) : 0;
                    conn.Close();
                }
            }
            return seatsCount;
        }

        private string GetCatCodeForFixture(int fixtureID)
        {
            string catCode = null;
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                string sqlQuery = @"
                SELECT SI.CatCode
                FROM SaleItems SI
                JOIN Sales S ON SI.SaleID = S.SaleID
                WHERE S.FixtureID = :FixtureID";
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(new OracleParameter(":FixtureID", fixtureID));
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    catCode = result != null ? result.ToString() : null;
                    conn.Close();
                }
            }
            return catCode;
        }


        // Method to update the sale status to canceled
        private void UpdateSaleStatus(Sale sale)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                string sqlQuery = "UPDATE Sales SET Cancel_Sale = :CancelSale WHERE SaleID = :SaleID";
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(new OracleParameter(":CancelSale", sale.GetCancelSale()));
                    cmd.Parameters.Add(new OracleParameter(":SaleID", sale.GetSaleID()));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

    }
}
