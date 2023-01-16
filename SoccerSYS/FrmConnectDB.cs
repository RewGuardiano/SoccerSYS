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
    public partial class FrmConnectDB : Form
    {
        OracleConnection conn = new OracleConnection(DBConnect.oradb);
        public FrmConnectDB()
        {
            InitializeComponent();
        }

        private void btnOpenConnection_Click(object sender, EventArgs e)
        {
            conn.Open();
            lblStatusConnection.Text = "Connection Opened;

        }

        private void btnCloseConnection_Click(object sender, EventArgs e)
        {
            conn.Close();
            lblStatusConnection.Text = " Connection Closed";
        }
    }
}
