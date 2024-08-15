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
            int totalCategories = 0;
            int totalSeatsSold = 0;

            // Load sales data
            string statsQuery = @"
            SELECT CatCode, 
                   SUM(Quantity) AS Total_Quantity 
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

                    // Accumulate total seats sold
                    totalSeatsSold += seatsSold;
                    totalCategories++;
                }

                // Calculate average seats sold per fixture
                string fixtureQuery = @"
                SELECT CatCode, 
                       COUNT(DISTINCT SaleID) AS Fixture_Count 
                FROM SaleItems 
                WHERE Is_Cancel <> 'Y' 
                GROUP BY CatCode";
                DataSet fixtureDs = loadChart(fixtureQuery);

                float totalAvgTicketsPerFixture = 0;
                int fixtureCategories = 0;

                if (fixtureDs.Tables.Count > 0 && fixtureDs.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in fixtureDs.Tables[0].Rows)
                    {
                        string categoryCode = row["CatCode"].ToString();
                        int fixtureCount = Convert.ToInt32(row["Fixture_Count"]);

                        // Get total quantity of tickets for this category
                        DataRow[] ticketRows = ds.Tables[0].Select($"CatCode = '{categoryCode}'");
                        int ticketsSold = ticketRows.Length > 0 ? Convert.ToInt32(ticketRows[0]["Total_Quantity"]) : 0;

                        // Calculate the average tickets per fixture for this category
                        float avgTicketsPerFixture = fixtureCount > 0 ? (float)ticketsSold / fixtureCount : 0;
                        totalAvgTicketsPerFixture += avgTicketsPerFixture;
                        fixtureCategories++;
                    }
                }

                // Calculate overall average and round to nearest whole number
                int avgTicketsPerFixtureOverall = fixtureCategories > 0 ? (int)Math.Round(totalAvgTicketsPerFixture / fixtureCategories) : 0;

                // Display results
                txtMostTicket.Text = mostPopularCategories.Trim();
                txtLeastTicket.Text = leastPopularCategories.Trim();
                txtAvgTickets.Text = $"{avgTicketsPerFixtureOverall} tickets per fixture";
            }
            else
            {
                // Handle the case where no data is available
                MessageBox.Show("No data available for statistics.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
