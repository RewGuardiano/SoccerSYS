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
using System.Globalization;

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
           // Populates the DataGridView with Sale data.
            LoadSalesData();
        }

        private void LoadSalesData()
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
                {
                    string query = @"
                    SELECT 
                        S.SaleID, 
                        S.Email, 
                        S.Sale_Time, 
                        S.Sub_Total, 
                        S.FixtureID,
                        SI.Is_Cancel,
                        SI.SaleItem_ID, 
                        SI.CatCode, 
                        SI.Quantity, 
                        SI.Total_Price
                    FROM Sales S
                    JOIN SaleItems SI ON S.SaleID = SI.SaleID
                    WHERE SI.Is_Cancel <> 'Y'";  // Exclude canceled sales

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
                    grdSales.Columns["Is_Cancel"].HeaderText = "Is_Cancel";
                    grdSales.Columns["SaleItem_ID"].HeaderText = "Sale Item ID";
                    grdSales.Columns["CatCode"].HeaderText = "Category Code";
                    grdSales.Columns["Quantity"].HeaderText = "Quantity";
                    grdSales.Columns["Total_Price"].HeaderText = "Total Price";

                    // Hide specific columns
                    grdSales.Columns["SaleItem_ID"].Visible = false;
                    grdSales.Columns["Sub_Total"].Visible = false;
                    grdSales.Columns["Is_Cancel"].Visible = false;

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
                txtTotSales.Text = $"€{Convert.ToDecimal(grdSales.Rows[e.RowIndex].Cells["Total_Price"].Value)}";
                txtMatchID.Text = grdSales.Rows[e.RowIndex].Cells["FixtureID"].Value.ToString();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // Validate and parse SaleID
            string saleIDText = txtSaleID.Text;
            if (int.TryParse(saleIDText, out int saleID))
            {
                if (grdSales.CurrentRow != null)
                {
                    int saleItemID = Convert.ToInt32(grdSales.CurrentRow.Cells["SaleItem_ID"].Value);
                    string email = txtEmail.Text;
                    int fixtureID = Convert.ToInt32(txtMatchID.Text);
                    decimal totalSales = Convert.ToDecimal(txtTotSales.Text.Substring(1)); // Remove currency symbol

                    try
                    {
                        // Get the CatCode and Quantity for the selected sale item
                        var (catCode, quantity) = GetCatCodeAndQuantityForSaleItem(saleID, saleItemID);

                        if (catCode != null)
                        {
                            
                            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to return Sale ID: {txtSaleID.Text}?", "Return Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (dialogResult == DialogResult.Yes)
                            {
                                // Update the sale status to canceled
                                UpdateSaleStatus(saleID, saleItemID);

                                // Update available seats
                                UpdateAvailableSeats(catCode, fixtureID, quantity);

                                // Remove the row from DataGridView
                                grdSales.Rows.Remove(grdSales.CurrentRow);

                                // Update the sale's subtotal
                                UpdateSaleSubTotal(totalSales, saleID);

                                // Reset UI
                                TextBox[] txtBoxes = { txtSaleID, txtEmail, txtTotSales, txtMatchID };
                                foreach (TextBox textBox in txtBoxes)
                                {
                                    textBox.Clear();
                                }
                                grpSaleDetails.Visible = false;

                                MessageBox.Show($"Successfully returned Sale ID: {txtSaleID.Text}", "Return Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sale item details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("No sale item selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid Sale ID format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateSaleSubTotal(decimal price, int saleID)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                string sqlQuery = "UPDATE Sales SET Sub_Total = Sub_Total - :price WHERE SaleID = :SaleID";
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(new OracleParameter(":price", OracleDbType.Decimal)).Value = price;
                    cmd.Parameters.Add(new OracleParameter(":SaleID", OracleDbType.Int32)).Value = saleID;

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show("Oracle error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        // Helper method to get the CatCode and Quantity related to the sale item
        private (string CatCode, int Quantity) GetCatCodeAndQuantityForSaleItem(int saleID, int saleItemID)
        {
            string catCode = null;
            int quantity = 0;

            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                string sqlQuery = "SELECT CatCode, Quantity FROM SaleItems WHERE SaleID = :SaleID AND SaleItem_ID = :SaleItem_ID";
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(new OracleParameter(":SaleID", saleID));
                    cmd.Parameters.Add(new OracleParameter(":SaleItem_ID", saleItemID));
                    conn.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            catCode = reader["CatCode"].ToString();
                            quantity = Convert.ToInt32(reader["Quantity"]);
                        }
                    }
                    conn.Close();
                }
            }

            return (catCode, quantity);
        }

        private void UpdateAvailableSeats(string catCode, int fixtureID, int seatsToReturn)
        {
            // Fetch the current number of available seats for this CatCode and FixtureID
            int currentAvailableSeats = FixtureSeats.GetAvailableSeats(catCode, fixtureID);

            // Calculate new available seats
            int newAvailableSeats = currentAvailableSeats + seatsToReturn;

            // Update available seats in the FixtureSeats table
            FixtureSeats.UpdateAvailableSeats(catCode, fixtureID, newAvailableSeats);
        }

        // Method to update the sale status to canceled
        private void UpdateSaleStatus(int saleID, int saleItemID)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                string sqlQuery = "UPDATE SaleItems SET Is_Cancel = 'Y' WHERE SaleID = :SaleID AND SaleItem_ID = :SaleItem_ID";
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(new OracleParameter(":SaleID", OracleDbType.Int32)).Value = saleID;
                    cmd.Parameters.Add(new OracleParameter(":SaleItem_ID", OracleDbType.Int32)).Value = saleItemID;

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show("Oracle error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }
    }
}