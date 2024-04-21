using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Windows.Forms;

namespace SoccerSYS
{
    class Sale
    {
        private int SaleID;
        private string Email;
        private int FixtureID;
        private string Sale_Time;
        private int Sub_Total;
        private char Cancel_Sale;
        private OracleCommand cmd;
        private OracleConnection conn = new OracleConnection(DBConnect.oradb);
        private OracleDataReader dr;

     
        

        public Sale(string email, int fixtureID, string sale_Time, int sub_Total, char cancelSale)
        {
            SaleID = getPreviousSale_ID() + 1;
            Email = email;
            FixtureID = fixtureID;
            Sale_Time = sale_Time;
            Sub_Total = sub_Total;
            Cancel_Sale = cancelSale;
        }

        public int GetSaleID()
        {
            return SaleID;
        }

        // Setter for SaleID
        public void SetSaleID(int saleID)
        {
            SaleID = saleID;
        }

        // Getter for Email
        public string GetEmail()
        {
            return Email;
        }

        // Setter for Email
        public void SetEmail(string email)
        {
            Email = email;
        }

        // Getter for fixtureID
        public int GetFixtureID()
        {
            return FixtureID;
        }

        // Setter for fixtureID
        public void SetFixtureID(int fixtureID)
        {
            FixtureID = fixtureID;
        }

        // Getter for CancelSale
        public char GetCancelSale()
        {
            return Cancel_Sale;
        }

        // Setter for CancelSale
        public void SetCancelSale(char cancelSale)
        {
            Cancel_Sale = cancelSale;
        }
        public string getSale_Time()
        {
            return Sale_Time;
        }
        public void setSale_Time(string saleTime)
        {
            Sale_Time = saleTime;
        }
        public int getSub_Total()
        {
            return Sub_Total;
        }
        public void setSub_Total(int subTotal)
        {
            Sub_Total = subTotal;
        }


        


        public void addSale()
        {

            string sqlQuery = "INSERT INTO Sales (SaleID,Email,FixtureId,Sale_Time,Sub_Total,Cancel_Sale) " +
                    "VALUES (:SaleID, :Email, :FixtureID, TO_DATE(:Sale_Time,'YYYY-MM-DD'), :Sub_Total, :CancelSale)";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();    

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.Parameters.Add(new OracleParameter(":SaleID", this.SaleID));
            cmd.Parameters.Add(new OracleParameter(":Email", this.Email));
            cmd.Parameters.Add(new OracleParameter(":FixtureID", this.FixtureID));
            cmd.Parameters.Add(new OracleParameter(":Sale_Time",this.Sale_Time));
            cmd.Parameters.Add(new OracleParameter(":Sub_Total", this.Sub_Total));
            cmd.Parameters.Add(new OracleParameter(":CancelSale", this.Cancel_Sale));

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        private int getPreviousSale_ID()
        {
            string sqlquery = "SELECT MAX (SaleID) From Sales";

            cmd = new OracleCommand(sqlquery, conn);

            conn.Open();

            dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                if (!dr.IsDBNull(0))
                {
                    int prevID = dr.GetInt32(0);
                    conn.Close();
                    return prevID;
                }
                else
                {
                    MessageBox.Show("No SaleID found, Have set Sale ID as 1", "Getting Sale ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            dr.Close();
            conn.Close();
            return 0;
        }
    }
    /*
    public static void getSale(int TicketID)
    {
        OracleConnection conn = new OracleConnection(DBConnect.oradb);

        string sqlQuery = "SELECT * FROM CATEGORYS WHERE TicketID = :ticketID";

        OracleCommand cmd = new OracleCommand(sqlQuery, conn);

        cmd.Parameters.Add(new OracleParameter("ticketID", TicketID));

        conn.Open();

        OracleDataReader dr = cmd.ExecuteReader();
        dr.Read();





        conn.Close();


    }*/



}


    
    

