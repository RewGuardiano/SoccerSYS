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
    public partial class frmYearlyTicketAnalysis : Form
    {
        private static new Form Parent;
        string loadQuery = "SELECT CatCode as category, SUM(quantity) as total_quantity FROM SaleItems WHERE Is_Cancel <> 'Y' GROUP BY CatCode ORDER BY CatCode";
        public frmYearlyTicketAnalysis(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            this.Close();
            Parent.Visible = true;
        }

        private void frmYearlyTicketAnalysis_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Visible = true;
        }

        private void frmYearlyTicketAnalysis_Load(object sender, EventArgs e)
        {
            try
            {

                // Configure the chart
                chartPopularity.Titles.Clear(); 
                chartPopularity.Titles.Add("Popularity Analysis");
                chartPopularity.Titles[0].Font = new Font("Calibri", 16, FontStyle.Bold);
                chartPopularity.ChartAreas[0].BackColor = Color.DimGray;
                chartPopularity.ChartAreas[0].AxisX.Title = "Category";
                chartPopularity.ChartAreas[0].AxisY.Title = "Total Quantity";
                chartPopularity.ChartAreas[0].AxisX.TitleFont = new Font("Calibri", 12, FontStyle.Bold);
                chartPopularity.ChartAreas[0].AxisY.TitleFont = new Font("Calibri", 12, FontStyle.Bold);

                // Load the data into the chart
                DataSet ds = loadChart(loadQuery);

                // Check if data is available
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    chartPopularity.DataSource = ds.Tables[0];
                    chartPopularity.Series.Clear();

                    var series = new System.Windows.Forms.DataVisualization.Charting.Series("Total Quantity")
                    {
                        ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column,
                        XValueMember = "category",
                        YValueMembers = "total_quantity",
                        IsValueShownAsLabel = true,
                        LabelForeColor = Color.Black,
                        Font = new Font("Calibri", 10)
                    };

                    chartPopularity.Series.Add(series);
                    chartPopularity.DataBind();

                    chartPopularity.ChartAreas[0].AxisX.Interval = 1;
                    chartPopularity.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                    chartPopularity.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
                    chartPopularity.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                    chartPopularity.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
                    getStats();

                    // Get average categories per fixture
                    getAvgCategoriesPerFixture();
                }
                else
                {
                    MessageBox.Show("No data available to display.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Oracle error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataSet loadChart(string sqlQuery)
        {

            DataSet ds = new DataSet();

           
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                try
                {
                    
                    conn.Open();

                   
                    using (OracleDataAdapter adapt = new OracleDataAdapter(sqlQuery, conn))
                    {
                        
                        adapt.Fill(ds);
                    }
                }
                catch (OracleException ex)
                {
                    //Debugging
                    MessageBox.Show($"Oracle error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                   
                    MessageBox.Show($"General error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return ds;
        }

        //This method gets the most popular Category Seat Code, least popular Category Seat Code  and average seats sold per match and display them in textboxes
        public void getStats()
        {
            string mostPopularCategories = "";
            int mostSeatsSold = 0;
            string leastPopularCategories = "";
            int leastSeatsSold = int.MaxValue; // Start with a very high value

            try
            {
                // Load sales data
                string statsQuery = @"SELECT CatCode, SUM(Quantity) AS Total_Quantity 
                FROM SaleItems 
                WHERE Is_Cancel <> 'Y' 
                GROUP BY CatCode";
                DataSet ds = loadChart(statsQuery);

                // Check if data is available
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    // Iterate through the rows of the DataTable
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        int seatsSold = Convert.ToInt32(row["Total_Quantity"]);
                        string categoryCode = row["CatCode"].ToString();

                        // Determine the category with most seats sold
                        if (seatsSold > mostSeatsSold)
                        {
                            mostSeatsSold = seatsSold;
                            mostPopularCategories = $"{categoryCode} - {mostSeatsSold} seats\n";
                        }
                        else if (seatsSold == mostSeatsSold)
                        {
                            mostPopularCategories += $"{categoryCode} - {seatsSold} seats\n";
                        }

                        // Determine the category with least seats sold
                        if (seatsSold < leastSeatsSold)
                        {
                            leastSeatsSold = seatsSold;
                            leastPopularCategories = $"{categoryCode} - {leastSeatsSold} seats\n";
                        }
                        else if (seatsSold == leastSeatsSold)
                        {
                            leastPopularCategories += $"{categoryCode} - {seatsSold} seats\n";
                        }
                    }

                    // Display results
                    txtMostTicket.Text = mostPopularCategories.Trim();
                    txtLeastTicket.Text = leastPopularCategories.Trim();
                }
                else
                {
                    // Handle the case where no data is available
                    MessageBox.Show("No data available for statistics.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Oracle error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void getAvgCategoriesPerFixture()
        {
            try
            {
                // Query to count distinct categories per fixture
                string categoriesPerFixtureQuery = @"
                SELECT SaleID, COUNT(DISTINCT CatCode) AS Category_Count
                FROM SaleItems
                WHERE Is_Cancel <> 'Y'
                GROUP BY SaleID";

                DataSet categoriesDs = loadChart(categoriesPerFixtureQuery);

                int totalFixtures = 0;
                int totalCategories = 0;

                if (categoriesDs.Tables.Count > 0 && categoriesDs.Tables[0].Rows.Count > 0)
                {
                    // Calculate total number of categories and fixtures
                    foreach (DataRow row in categoriesDs.Tables[0].Rows)
                    {
                        int categoryCount = Convert.ToInt32(row["Category_Count"]);
                        totalCategories += categoryCount;
                        totalFixtures++;
                    }

                    // Calculate average number of categories per fixture
                    int avgCategoriesPerFixture = totalFixtures > 0 ? (int)Math.Round((double)totalCategories / totalFixtures) : 0;
                    Console.WriteLine(avgCategoriesPerFixture);

                    // Display the result
                    txtAvgTickets.Text = $"{avgCategoriesPerFixture} categories per fixture";
                    Console.WriteLine(txtAvgTickets);
                }
                else
                {
                    // Handle the case where no data is available
                    MessageBox.Show("No data available to calculate average categories per fixture.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Oracle error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
