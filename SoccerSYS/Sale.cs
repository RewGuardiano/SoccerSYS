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
        private int TicketID;
        private int Quantity;
        private int Salefee;
    





        public Sale()
        {
            this.SaleID = 0;
            this.TicketID = 0;
            this.Quantity = 0;
            this.Salefee = 0;
            

        }
        public Sale(int saleId, int ticketid, int quantity, int salefee)
        {
            this.SaleID = saleId;
            this.TicketID = ticketid;
            this.Quantity = quantity;
            this.Salefee = salefee;
           




        }
        public int saleId()
        {
            return this.SaleID;
        }
        public int geticketid()
        {
            return this.TicketID;

        }
        public int getquantity()
        {
            return this.Quantity;
        }
        public int getsalefee()
        {
            return this.Salefee;
        }


        public void setSaleId(int saleid)
        {
            this.SaleID = saleid;

        }
        public void setTicketID(int ticketid)
        {
            this.TicketID = ticketid;
        }
        public void setSaleFee(int salefee)
        {
            this.SaleID = salefee;
        }
       
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

          
        }


        public static DataSet FindSale(int TicketID) {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            // Open connection
            conn.Open();

            // Define SQL command to retrieve data from Category table
            string sql = "SELECT * FROM CATEGORYS WHERE TicketID = :ticketID";

            // Create command object
            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(new OracleParameter("ticketID", TicketID));

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Cat");

            conn.Close();

            return ds;


        }
        public void ConfirmSales()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            string sqlQuery = "INSERT INTO Sale (SALEID, TICKETID, QUANTITY, Salefee) " +
                              "VALUES (:saleid, :ticketid, :quantity, :salefee)";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.Parameters.Add(new OracleParameter(":saleID", this.SaleID));
            cmd.Parameters.Add(new OracleParameter(":ticketID", this.TicketID));
            cmd.Parameters.Add(new OracleParameter(":quantity", this.Quantity));
            cmd.Parameters.Add(new OracleParameter(":salefee", this.Salefee));
          
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }


    }
    

