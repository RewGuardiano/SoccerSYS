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
        public frmYearlyTicketAnalysis(Form parent)
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

        private void frmYearlyTicketAnalysis_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Visible = true;
        }
    }
}
