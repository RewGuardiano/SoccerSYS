using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace SoccerSYS
{
        class Sale
        {
            private int SaleID;
            private int TicketID;
            private int Quantity;
            private int Salefee;
            private int MatchID;
          




            public Sale()
            {
                this.SaleID = 0;
                this.TicketID = 0;
                this.Quantity = 0;
                this.Salefee = 0;
                this.MatchID = 0;
              

            }
            public Sale(int saleId, int ticketid, int quantity, int salefee, int matchid,String ticketype)
            {
                this.SaleID = saleId;
                this.TicketID = ticketid;
                this.Quantity = quantity;
                this.Salefee = salefee;
                this.MatchID = matchid;
              
            


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

        public void getSale(int TicketID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT * FROM CATEGORIES WHERE TicketID =  " + TicketID;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            conn.Close();


        }
       /*public static DataSet FindSale(int TicketId)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT TicketID,CatCode,Description,Price,NoSeats,SeatFrom,SeatTo,Status From Categories " +
                "WHERE TicketID LIKE '%" +  + "%' ORDER BY TicketID";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);


            OracleDataAdapter da = new OracleDataAdapter(cmd);



            DataSet ds = new DataSet();
            da.Fill(ds, "Cat");

            conn.Close();

            return ds;

        }
       */




    }
    }

