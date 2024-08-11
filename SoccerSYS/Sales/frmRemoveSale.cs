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
            DialogResult dialog = MessageBox.Show("Are you sure you want to Exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
            frmMainMenu to = new frmMainMenu();
            to.Show();
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
                        SI.SaleItem_ID, 
                        SI.CatCode, 
                        SI.Quantity, 
                        SI.Total_Price
                    FROM Sales S
                    JOIN SaleItems SI ON S.SaleID = SI.SaleID";

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
                    grdSales.Columns["SaleItem_ID"].HeaderText = "Sale Item ID";
                    grdSales.Columns["CatCode"].HeaderText = "Category Code";
                    grdSales.Columns["Quantity"].HeaderText = "Quantity";
                    grdSales.Columns["Total_Price"].HeaderText = "Total Price";

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
    }
}
