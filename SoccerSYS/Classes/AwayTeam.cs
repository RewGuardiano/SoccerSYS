using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace SoccerSYS.Classes
{
    class AwayTeam
    {
        private string awayTeam_ID;
        private string TeamName;

        public AwayTeam(string awayTeam_ID, string teamName)
        {
            this.awayTeam_ID = awayTeam_ID;
            TeamName = teamName;
        }

        public string GetAwayTeamID()
        {
            return awayTeam_ID;
        }

        // Setter for awayTeam_ID
        public void SetAwayTeamID(string awayTeamID)
        {
            awayTeam_ID = awayTeamID;
        }

        // Getter for TeamName
        public string GetTeamName()
        {
            return TeamName;
        }

        // Setter for TeamName
        public void SetTeamName(string teamName)
        {
            TeamName = teamName;
        }
        public override string ToString()
        {
            return TeamName; // Override ToString() to return TeamName
        }
        public static void viewAllTeams(ref List<AwayTeam> allTeams)
        {
            allTeams = new List<AwayTeam>();
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();

            string sqlQuery = "SELECT AwayTeam_ID,TeamName FROM AwayTeams ORDER BY TeamName";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                string awayTeam_ID = dr.GetString(0);
                string teamName = dr.GetString(1);


                allTeams.Add(new AwayTeam(awayTeam_ID, teamName));
            }
            dr.Close();
        }

        public void UpdateFixtureAwayTeams()
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
                {
                    conn.Open();

                    // Update AwayTeams table
                    string updateTeamNameQuery = "UPDATE AwayTeams SET TeamName = :teamName WHERE AwayTeam_ID = :awayTeam_ID";
                    using (OracleCommand cmd = new OracleCommand(updateTeamNameQuery, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("teamName", OracleDbType.Varchar2)).Value = this.TeamName;
                        cmd.Parameters.Add(new OracleParameter("awayTeam_ID", OracleDbType.Varchar2)).Value = this.awayTeam_ID;
                        cmd.ExecuteNonQuery();
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating team: " + ex.Message);
                // Optionally handle or log the exception
            }
        }
    }

    }

