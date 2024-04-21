using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace SoccerSYS
{
    class Sale
    {
        private int SaleID;
        private string Email;
        private int fixtureID;
        private bool CancelSale;

        public Sale(int saleID, string email, int fixtureID )
        {
            SaleID = saleID;
            Email = email;
            this.fixtureID = fixtureID;
            CancelSale = false;
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
            return fixtureID;
        }

        // Setter for fixtureID
        public void SetFixtureID(int fixtureID)
        {
            this.fixtureID = fixtureID;
        }

        // Getter for CancelSale
        public bool GetCancelSale()
        {
            return CancelSale;
        }

        // Setter for CancelSale
        public void SetCancelSale(bool cancelSale)
        {
            CancelSale = cancelSale;
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


    
    

