﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using SoccerSYS.Classes;

namespace SoccerSYS
{
    class Fixtures
    {
        internal int FixtureID;
        internal string AwayTeam_ID;
        internal string Fixture_Time;
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
                
            }
            dr.Close();

            conn.Close();
            return 0;
        }



  
        public int GetFixtureID()
        {
            return FixtureID;
        }

        public void SetFixtureID(int fixtureID)
        {
            FixtureID = fixtureID;
        }

 
        public string GetAwayTeamID()
        {
            return AwayTeam_ID;
        }

    
        public void SetAwayTeamID(string awayTeamID)
        {
            AwayTeam_ID = awayTeamID;
        }

        
        public string GetFixtureTime()
        {
            return Fixture_Time;
        }

       
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

            // After creating the fixture, populate FixtureSeats
            PopulateFixtureSeats();
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

        internal void UpdateFixture(string fixtureID, string awayTeamID, string fixtureTime)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
                {
                    conn.Open();

                    // Update the Fixtures table
                    string updateQuery = @"UPDATE Fixtures SET Fixture_Time = TO_DATE(:fixtureTime, 'DD-MON-YY'),AwayTeam_ID = :awayTeam_ID WHERE FixtureID = :fixtureID";

                    using (OracleCommand cmd = new OracleCommand(updateQuery, conn))
                    {
                        
                        cmd.Parameters.Add(new OracleParameter("fixtureTime", fixtureTime));
                        cmd.Parameters.Add(new OracleParameter("awayTeam_ID", awayTeamID));
                        cmd.Parameters.Add(new OracleParameter("fixtureID", fixtureID));

                        
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("No rows were updated. Please check the FixtureID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating fixture: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PopulateFixtureSeats()
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);
                conn.Open();

                // Retrieve all categories to populate FixtureSeats
                string getCategoriesQuery = "SELECT CatCode, MaxSeats FROM Categories";
                OracleCommand cmd = new OracleCommand(getCategoriesQuery, conn);
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string catCode = dr["CatCode"].ToString();
                    int maxSeats = Convert.ToInt32(dr["MaxSeats"]);

                    string insertFixtureSeatQuery = $"INSERT INTO FixtureSeats (FixtureID, CatCode, AvailableSeats) " +
                                                    $"VALUES ({this.FixtureID}, '{catCode}', {maxSeats})";

                    OracleCommand insertCmd = new OracleCommand(insertFixtureSeatQuery, conn);
                    insertCmd.ExecuteNonQuery();
                }

                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating FixtureSeats: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    


    






























