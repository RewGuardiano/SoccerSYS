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
                chartPopularity.Titles.Clear(); // Clear any existing titles
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



    }
}
