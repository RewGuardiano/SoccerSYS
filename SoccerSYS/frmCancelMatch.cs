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
    public partial class frmCancelMatch : Form
    {
        //Error couldn't create a fixture object//
        //Fixture theMatch = new Fixture();//
        public frmCancelMatch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Are you sure you want to Exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
            frmMainMenu to = new frmMainMenu();
            to.Show();
            this.Close();
        }

        private void grpCategory_Enter(object sender, EventArgs e)
        {
           

        }

        private void btnCancelSubmit_Click(object sender, EventArgs e)
        {
            /*
DialogResult dialog = MessageBox.Show("Are you sure you want to remove?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                TheMatch.setMatchID(cobMatchID.Text);
                TheMatch.RemoveMatch();
                MessageBox.Show("Match Availability set to Unavailable", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                this.Close();

                frmMainMenu to = new frmMainMenu();
                to.Show();
            }*/

    }

        private void btnSearchCancelMatch_Click(object sender, EventArgs e)
        {
            grdMatchRemove.DataSource = Category.FindCategory(txtSearchCancelMatch.Text).Tables["MatchID"];

            if (grdMatchRemove.Rows.Count == 1)
            {
                MessageBox.Show("No Data Found");
                txtSearchCancelMatch.Focus();
                return;
            }
        }

        private void grdMatchRemove_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //String MatchID.toString(grdMatchRemove.Rows[grdMatchRemove.CurrentCell.RowIndex].Cells[0].Value.ToString());

           // TheMatch.getCategory(MatchID);
        }








        //The match Status would become unavailable after canceling match.
    }
}
