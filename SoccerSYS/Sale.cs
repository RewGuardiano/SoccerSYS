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
        private int MatchID;
        private char TicketStatus;





        public Sale()
        {
            this.SaleID = 0;
            this.TicketID = 0;
            this.Quantity = 0;
            this.Salefee = 0;
            this.MatchID = 0;
            this.TicketStatus = ' ';

        }
        public Sale(int saleId, int ticketid, int quantity, int salefee, int matchid, String ticketype, char ticketstatus)
        {
            this.SaleID = saleId;
            this.TicketID = ticketid;
            this.Quantity = quantity;
            this.Salefee = salefee;
            this.MatchID = matchid;
            this.TicketStatus = ticketstatus;




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
        public int getmatchid()
        {
            return this.MatchID;

        }
        public char getTicketStatus()
        {
            return this.TicketStatus;
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
        public void setMatchID(int matchId)
        {
            this.MatchID = matchId;

        }

        public void setticketStatus(char ticketStatus)
        {
            this.TicketStatus = ticketStatus;
        }

        public static void getSale(String CatCode)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            string sqlQuery = "SELECT * FROM CATEGORIES JOIN SALES ON Categories.TicketID = Sales.TicketID";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();




            
            conn.Close();

          
        }


        public static DataSet FindSale(String CatCode) {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            // Open connection
            conn.Open();

            // Define SQL command to retrieve data from Category table
            string sql = "SELECT * FROM CATEGORIES JOIN SALES ON Categories.TicketID = Sales.TicketID";



            // Create command object
            OracleCommand cmd = new OracleCommand(sql, conn);
       

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Cat");

          

            conn.Close();

            return ds;

            Console.WriteLine("Data inserted successfully.");
        }

    }


    }
    

