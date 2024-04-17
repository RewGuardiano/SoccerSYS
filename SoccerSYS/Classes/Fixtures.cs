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
        private int FixtureID;
        private char AwayTeam_ID;
        private DateTime Fixture_Time;

        public Fixtures(int fixtureID, char awayTeam_ID, DateTime fixture_Time)
        {
            FixtureID = fixtureID;
            AwayTeam_ID = awayTeam_ID;
            Fixture_Time = fixture_Time;
        }

        // Getter for FixtureID
        public int GetFixtureID()
        {
            return FixtureID;
        }

        // Setter for FixtureID
        public void SetFixtureID(int fixtureID)
        {
            FixtureID = fixtureID;
        }

        // Getter for AwayTeam_ID
        public char GetAwayTeamID()
        {
            return AwayTeam_ID;
        }

        // Setter for AwayTeam_ID
        public void SetAwayTeamID(char awayTeamID)
        {
            AwayTeam_ID = awayTeamID;
        }

        // Getter for Fixture_Time
        public DateTime GetFixtureTime()
        {
            return Fixture_Time;
        }

        // Setter for Fixture_Time
        public void SetFixtureTime(DateTime fixtureTime)
        {
            Fixture_Time = fixtureTime;
        }

    }
      
      /*
        public void ScheduleMatch()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            string sqlQuery = "INSERT INTO FIXTURES (MatchID,TeamID,Match_Date,Match_time, TicketSold, MatchAvailability) " +
                              "VALUES (:matchid,:teamid,:match_date,:match_time, :ticketsold, :matchavailability)";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.Parameters.Add(new OracleParameter(":MatchID", this.MatchID));
            cmd.Parameters.Add(new OracleParameter(":TeamID", this.TeamID));
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
      */

    }





























