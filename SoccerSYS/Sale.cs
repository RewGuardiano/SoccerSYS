using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerSYS
{
        class Sale
        {
            private int SaleID;
            private int TicketID;
            private int Quantity;
            private int Salefee;
            private int MatchID;
            private String TicketType;




            public Sale()
            {
                this.SaleID = 0;
                this.TicketID = 0;
                this.Quantity = 0;
                this.Salefee = 0;
                this.MatchID = 0;
                this.TicketType = "";

            }
            public Sale(int saleId, int ticketid, int quantity, int salefee, int matchid,String ticketype)
            {
                this.SaleID = saleId;
                this.TicketID = ticketid;
                this.Quantity = quantity;
                this.Salefee = salefee;
                this.MatchID = matchid;
                this.TicketType = ticketype;
            


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
            public string getTicketType()
        {
            return this.TicketType;
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

            public void setTicketTtype(string ticketType)
        {
            this.TicketType = ticketType;
        }

        



        }
    }

