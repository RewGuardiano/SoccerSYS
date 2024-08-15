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
using System.Windows.Forms.DataVisualization.Charting;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SoccerSYS
{
    public partial class frrmYearlyRevenueAnalysis : Form
    {
        private static new Form Parent;
        OracleConnection conn = new OracleConnection(DBConnect.oradb);
        string loadQuery = "SELECT TO_CHAR(Fixture_Time, 'MM') AS sales_month, SUM(sub_total) AS monthly_revenue FROM Sales s JOIN Fixtures f ON s.fixtureid = f.fixtureid GROUP BY TO_CHAR(Fixture_Time, 'MM') ORDER BY TO_CHAR(Fixture_time, 'MM')";
        public frrmYearlyRevenueAnalysis(Form parent)
        {
            InitializeComponent();
            Parent = parent;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
            
        }

        private void frrmYearlyRevenueAnalysis_Load(object sender, EventArgs e)
        {
            try
            {
               
                // Configure the chart
                chartSales.Titles.Clear(); 
                chartSales.Titles.Add("Yearly Revenue Analysis");
                chartSales.Titles[0].Font = new Font("Calibri", 16, FontStyle.Bold);
                chartSales.ChartAreas[0].BackColor = Color.DimGray;
                chartSales.ChartAreas[0].AxisX.Title = "Month";
                chartSales.ChartAreas[0].AxisY.Title = "Monthly Revenue (€)";
                chartSales.ChartAreas[0].AxisX.TitleFont = new Font("Calibri", 12, FontStyle.Bold);
                chartSales.ChartAreas[0].AxisY.TitleFont = new Font("Calibri", 12, FontStyle.Bold);

                // Load the data into the chart
                DataSet ds = loadChart(loadQuery);

                // Check if data is available
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    chartSales.DataSource = ds.Tables[0];
                    chartSales.Series.Clear();

                    var series = new System.Windows.Forms.DataVisualization.Charting.Series("Monthly Revenue")
                    {
                        ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column,
                        XValueMember = "sales_month",
                        YValueMembers = "monthly_revenue",
                        IsValueShownAsLabel = true,
                        LabelForeColor = Color.Black,
                        Font = new Font("Calibri", 10)
                    };

                    chartSales.Series.Add(series);
                    chartSales.DataBind();

                    chartSales.ChartAreas[0].AxisX.Interval = 1;
                    chartSales.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                    chartSales.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
                    chartSales.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                    chartSales.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
                    getStats();
                  

                }
                else
                {
                    MessageBox.Show("No data available to display.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //Debugging
            // Handle Oracle-specific exceptions
            catch (OracleException ex)
            {
                MessageBox.Show($"Oracle error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Handle general exceptions
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
                    // Handle Oracle-specific exceptions
                    MessageBox.Show($"Oracle error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    // Handle general exceptions
                    MessageBox.Show($"General error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return ds;
        }

        private void frrmYearlyRevenueAnalysis_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Visible = true;
        }


        //This method gets the most monthly sales, least monthly sales, average sales and total sales per season and display them in textboxes
        public void getStats()
        {
            // Initialize variables for tracking sales data
            string mostSalesMonthName = "";
            decimal mostSales = decimal.MinValue;
            string leastSalesMonthName = "";
            decimal leastSales = decimal.MaxValue;
            decimal totSales = 0;

            // Load data into a DataSet
            DataSet ds = loadChart(loadQuery); 

            // Check if data is available
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                // Iterate through the rows of the DataTable
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    // Parse sales value from the DataRow
                    decimal sales = Convert.ToDecimal(row["monthly_revenue"]);

                    // Get month number and convert to month name
                    string monthNumber = row["sales_month"].ToString();
                    string monthName;

                    switch (monthNumber)
                    {
                        case "01": monthName = "January"; break;
                        case "02": monthName = "February"; break;
                        case "03": monthName = "March"; break;
                        case "04": monthName = "April"; break;
                        case "05": monthName = "May"; break;
                        case "06": monthName = "June"; break;
                        case "07": monthName = "July"; break;
                        case "08": monthName = "August"; break;
                        case "09": monthName = "September"; break;
                        case "10": monthName = "October"; break;
                        case "11": monthName = "November"; break;
                        case "12": monthName = "December"; break;
                        default: monthName = monthNumber; break; 
                    }

                    // Determine the month with most sales
                    if (sales > mostSales)
                    {
                        mostSales = sales;
                        mostSalesMonthName = monthName;
                    }

                    // Determine the month with least sales
                    if (sales < leastSales)
                    {
                        leastSales = sales;
                        leastSalesMonthName = monthName;
                    }

                    // Accumulate total sales
                    totSales += sales;
                }

                // Calculate average sales
                int numOfRows = ds.Tables[0].Rows.Count;
                float avgSales = numOfRows > 0 ? (float)(totSales / numOfRows) : 0;

                // Display results
                txtMostSales.Text = $"{mostSalesMonthName} - €{mostSales:N2}";
                txtLeastSales.Text = $"{leastSalesMonthName} - €{leastSales:N2}";
                txtAvgSales.Text = $"The average sales for {numOfRows} months is €{avgSales:N2}";
                txtTotOfSales.Text = $"€{totSales:N2}";
            }
            else
            {
                // Handle the case where no data is available
                MessageBox.Show("No data available for statistics.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
