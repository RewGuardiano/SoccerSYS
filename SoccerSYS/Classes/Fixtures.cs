using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace SoccerSYS
{
    class Fixtures
    {
        private int FixtureID;
        private string AwayTeam_ID;
        private string Fixture_Time;
        private OracleCommand cmd;
        private OracleConnection conn = new OracleConnection(DBConnect.oradb);
        private OracleDataReader dr;

        public Fixtures(string awayTeam_ID, string fixture_Time)
        {
            // Retrieve the previous FixtureID from your data source (e.g., database)
            int previousFixtureID = getPreviousFixtureID();

            // Calculate the new FixtureID by incrementing the previousFixtureID by 1
            int newFixtureID = previousFixtureID + 1;

            // Update the FixtureID property with the new value
            FixtureID = newFixtureID;

            AwayTeam_ID = awayTeam_ID;
            Fixture_Time = fixture_Time;
        }

        private int getPreviousFixtureID()
        {
            string sqlquery = "SELECT MAX (FixtureID) From Fixtures";


            conn.Open();
            cmd = new OracleCommand(sqlquery,conn);

            dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                if (!dr.IsDBNull(0))
                {
                    int prevID = dr.GetInt32(0);
                    conn.Close();
                    return prevID;
                }
                else
                {
                    MessageBox.Show("No FixtureID found, Have set fixture ID as 1", "Getting Fixture ID",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            dr.Close();

            conn.Close();
            return 0;
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
        public string GetAwayTeamID()
        {
            return AwayTeam_ID;
        }

        // Setter for AwayTeam_ID
        public void SetAwayTeamID(string awayTeamID)
        {
            AwayTeam_ID = awayTeamID;
        }

        // Getter for Fixture_Time
        public string GetFixtureTime()
        {
            return Fixture_Time;
        }

        // Setter for Fixture_Time
        public void SetFixtureTime(string fixtureTime)
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

            string sqlQuery = $"INSERT INTO Fixtures Values ('{this.FixtureID}'," +
                $"'{this.AwayTeam_ID}',TO_DATE('{this.Fixture_Time}','YYYY-MM-DD'))";


            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
          

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void getFixtureDetails(ref List<string> allFixtureDetails)
        {
            allFixtureDetails = new List<string>();
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();

            string sqlQuery = "SELECT f.fixtureID, t.TeamName FROM Fixtures f JOIN AwayTeams t ON f.AwayTeam_ID = t.AwayTeam_ID " +
                $"WHERE f.fixture_time >= SYSDATE ORDER BY t.TeamName";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string fixturedetails = $"{dr.GetString(0)} - {dr.GetString(1)}";

                allFixtureDetails.Add(fixturedetails);
            }

            dr.Close();
        }


    }
}





























