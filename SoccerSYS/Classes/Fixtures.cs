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

        public override string ToString()
        {
            return "FixtureID: " + FixtureID + "\nAwayTeam_ID: " + AwayTeam_ID + "\nFixture Time: " + Fixture_Time; 
        }


        public void Createfixture()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            string sqlQuery = "INSERT INTO FIXTURES (FixtureID,AwayTeam_ID,Fixture_Time) " +
                              "VALUES (:FixtureID,:Awayteam_id,:Fixture_time)";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.Parameters.Add(new OracleParameter(":FixutureID", this.FixtureID));
            cmd.Parameters.Add(new OracleParameter(":AwayTeamID", this.AwayTeam_ID));
            cmd.Parameters.Add(new OracleParameter(":Fixture_Time", this.Fixture_Time));

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }


    }
}





























