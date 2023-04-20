using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace SoccerSYS
{
    class Fixtures
    {
        private DateTime Match_Date;
        private int MatchID;
        private int TicketQuantity;
        private String Match_time;
        private int TicketsSold;
        private bool[,] SeatAvailability;




        public Fixtures(DateTime match_date, int matchId, int ticketQuantity, String match_time)
        {
            Match_Date = match_date;
            MatchID = matchId;
            TicketQuantity = ticketQuantity;
            Match_time = match_time;
            TicketsSold = 0;
            SeatAvailability = new bool[100, 100];

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

            string sqlQuery = "INSERT INTO FIXTURES (Match_Date, MatchID,TicketQuantity,Match_time, TicketSold, SeatAvailability) " +
                              "VALUES (:match_date, :matchid,ticketquantity, :match_time, :ticketsold, :seatavailability)";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.Parameters.Add(new OracleParameter(":Match_Date", this.Match_Date));
            cmd.Parameters.Add(new OracleParameter(":MatchID", this.MatchID));
            cmd.Parameters.Add(new OracleParameter(":TicketQuantity", this.TicketQuantity));
            cmd.Parameters.Add(new OracleParameter(":Match_time", this.Match_time));
            cmd.Parameters.Add(new OracleParameter(":TicketSold", this.TicketsSold));
            cmd.Parameters.Add(new OracleParameter(":SeatAvailability", this.SeatAvailability));
        
     
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}



























}
