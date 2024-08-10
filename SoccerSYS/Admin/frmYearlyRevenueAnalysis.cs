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
    public partial class frrmYearlyRevenueAnalysis : Form
    {
        private static new Form Parent;
        OracleConnection conn = new OracleConnection(DBConnect.oradb);
        string loadQuery = "SELECT TO_CHAR(sale_time, 'MM') AS sales_month, SUM(sub_total) AS monthly_revenue FROM sales GROUP BY TO_CHAR(sale_time, 'MM') ORDER BY TO_CHAR(sale_time, 'MM')";
        public frrmYearlyRevenueAnalysis(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMainMenu to = new frmMainMenu();
            to.Show();
            this.Close();
            Parent.Visible = true;
        }

        private void frrmYearlyRevenueAnalysis_Load(object sender, EventArgs e)
        {

            //chart1.Titles.Add("Popularity analysis chart");
            //chart1.Titles[0].Font = new Font("Calibri", 16, FontStyle.Bold);
            //chart1.ChartAreas[0].BackColor = Color.DimGray;
            //chart1.ChartAreas[0].AxisX.Title = "Month";
            //chart1.ChartAreas[0].AxisY.Title = "monthly_revenue";
            //chart1.ChartAreas[0].AxisX.TitleFont = new Font("Calibri", 12, FontStyle.Bold);
            //chart1.ChartAreas[0].AxisY.TitleFont = new Font("Calibri", 12, FontStyle.Bold);
            //chart1.DataSource = loadChart().Tables[0];
            //chart1.DataBind();
            //chart1.Series["monthly_revenue"].XValueMember = "sales_month";
            //chart1.Series["monthly_revenue"].YValueMembers = "monthly_revenue";
        }

        private DataSet loadChart()
        {
            DataSet ds = new DataSet();
            OracleDataAdapter adapt = new OracleDataAdapter(loadQuery, conn);
            adapt.Fill(ds);
            return ds;
        }

        private void frrmYearlyRevenueAnalysis_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Visible = true;
        }
    }
}
