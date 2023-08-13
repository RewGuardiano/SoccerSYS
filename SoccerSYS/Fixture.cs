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
        private string TeamID;
        private DateTime Match_Date;
        private string Match_time;
        private int TicketsSold;
        private char MatchAvailability;




        public Fixture(int MatchID,string TeamID,DateTime Match_Date, string Match_time, int TicketsSold, char MatchAvailability)
        {
            this.MatchID = MatchID;
            this.TeamID = TeamID;
            this.Match_Date = Match_Date;
            this.Match_time = Match_time;
            this.TicketsSold = TicketsSold;
            this.MatchAvailability = MatchAvailability;
           
        }
        public DateTime getmatchdate()
        {
            return this.Match_Date;
        }
        public int getmatchId()
        {
            return this.MatchID;

        }
        public string getTeamID()
        {
            return this.TeamID;
        }
        public string getMatchtime()
        {
            return this.Match_time;
        }
        public int getTicketSold()
        {
            return this.TicketsSold;
        }
       
        public int getMatchAvailability()
        {
            return this.MatchAvailability;
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
        public void setMatchAvailability(char matchAvailability)
        {
            setMatchAvailability('A');
           
        }
        public void setTeamID(string teamID)
        {
            TeamID = teamID;

        }
       
      


      
      
        public void ScheduleMatch()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            string sqlQuery = "INSERT INTO FIXTURES (MatchID, Match_Date,Match_time, TicketSold, MatchAvailability) " +
                              "VALUES (:match_date, :matchid,:match_time, :ticketsold, :matchavailability)";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.Parameters.Add(new OracleParameter(":MatchID", this.MatchID));
            cmd.Parameters.Add(new OracleParameter(":Match_Date", this.Match_Date));
            cmd.Parameters.Add(new OracleParameter(":Match_time", this.Match_time));
            cmd.Parameters.Add(new OracleParameter(":TicketSold", this.TicketsSold));
            cmd.Parameters.Add(new OracleParameter(":MatchAvailability ", this.MatchAvailability));
        
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void CancelMatch()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            string sqlQuery = "UPDATE Fixtures SET MatchAvailability='U' WHERE MatchID = :MatchID";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.Parameters.Add(new OracleParameter(":MatchID",MatchID ));

            cmd.ExecuteNonQuery();

            conn.Close();
        }


    }
}




























