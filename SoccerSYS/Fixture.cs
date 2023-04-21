using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace SoccerSYS
{
    class Fixture
    {
        private int MatchID;
        private DateTime Match_Date;
        private String Match_time;
        private int TicketsSold;
        private bool[,] SeatAvailability;
        private int SaleID;




        public Fixture(int matchId,DateTime match_date, string match_time, int ticketsSold, bool[,] seatAvailability,int saleID)
        {
            Match_Date = match_date;
            MatchID = matchId;
            Match_time = match_time;
            TicketsSold = 0;
            SeatAvailability = seatAvailability;
            SaleID = saleID;
        }
        public DateTime getmatchdate()
        {
            return this.Match_Date;
        }
        public int getmatchId()
        {
            return this.MatchID;

        }
        public string getMatchtime()
        {
            return this.Match_time;
        }
        public int getTicketSold()
        {
            return this.TicketsSold;
        }
        public bool[,]getSeatAvailability ()
        {
            return this.SeatAvailability;

        }
        public int getSaleID()
        {
            return this.SaleID;
        }
        public void setMatchDate(DateTime matchDate)
        {
            this.Match_Date = matchDate;

        }
        public void setMatchId(int matchid)
        {
            this.MatchID = matchid;
        }
        public void setMatchTime(string matchTime)
        {
            this.Match_time = matchTime;
        }
        public void setTicketSold(int ticketSold)
        {
            this.TicketsSold = ticketSold;

        }

        public void setSeatAvailability(bool[,] seatAvailability)
        {
            this.SeatAvailability = seatAvailability;
        }

      


        // Method to update the seat availability and number of tickets sold after a sale
        public void UpdateSeatAvailability(int row, int column)
        {
            if (SeatAvailability[row, column] == false)
            {
                SeatAvailability[row, column] = true;
                TicketsSold++;
            }
            else
            {
                Console.WriteLine("Error: Seat is already sold.");
            }
        }

        // Method to analyze seat availability and display the results
        public void AnalyzeSeatAvailability()
        {
            int availableSeats = 0;
            int soldSeats = 0;
            for (int i = 0; i < SeatAvailability.GetLength(0); i++)
            {
                for (int j = 0; j < SeatAvailability.GetLength(1); j++)
                {
                    if (SeatAvailability[i, j] == false)
                    {
                        availableSeats++;
                    }
                    else
                    {
                        soldSeats++;
                    }
                }
            }
            Console.WriteLine("Seat availability analysis:");
            Console.WriteLine("- Available seats: " + availableSeats);
            Console.WriteLine("- Sold seats: " + soldSeats);
        }
        public void ScheduleMatch()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            string sqlQuery = "INSERT INTO FIXTURES (MatchID, Match_Date,Match_time, TicketSold, SeatAvailability,SaleID) " +
                              "VALUES (:match_date, :matchid,:match_time, :ticketsold, :seatavailability,:saleID)";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.Parameters.Add(new OracleParameter(":MatchID", this.MatchID));
            cmd.Parameters.Add(new OracleParameter(":Match_Date", this.Match_Date));
            cmd.Parameters.Add(new OracleParameter(":Match_time", this.Match_time));
            cmd.Parameters.Add(new OracleParameter(":TicketSold", this.TicketsSold));
            cmd.Parameters.Add(new OracleParameter(":SeatAvailability", this.SeatAvailability));
            cmd.Parameters.Add(new OracleParameter(":SaleID", this.SaleID));

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}




























