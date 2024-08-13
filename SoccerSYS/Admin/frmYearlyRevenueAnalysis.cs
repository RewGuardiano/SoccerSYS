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
        string loadQuery = "SELECT TO_CHAR(Sale_Time, 'MM') AS sales_month, SUM(sub_total) AS monthly_revenue FROM Sales GROUP BY TO_CHAR(Sale_Time, 'MM') ORDER BY TO_CHAR(Sale_time, 'MM')";
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
                chartSales.Titles.Clear(); // Clear any existing titles
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

            // Ensure that the OracleConnection is properly initialized
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                try
                {
                    // Open the connection
                    conn.Open();

                    // Initialize the OracleDataAdapter with the provided query and connection
                    using (OracleDataAdapter adapt = new OracleDataAdapter(sqlQuery, conn))
                    {
                        // Fill the DataSet with the results of the query
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

       
    }
}
