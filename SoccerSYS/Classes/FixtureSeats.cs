using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace SoccerSYS
{
    internal class FixtureSeats
    {
        OracleConnection conn = new OracleConnection(DBConnect.oradb);

        private string CatCode;
        private int FixtureID;
        private int AvailableSeats;

        public FixtureSeats(string catCode, int fixtureID, int availableSeats)
        {
            CatCode = catCode;
            FixtureID = fixtureID;
            AvailableSeats = availableSeats;
        } 

        public string GetCatCode()
        {
            return CatCode;
        }

        public void SetCatCode(string catCode)
        {
            CatCode = catCode;
        }

        public int GetFixtureID()
        {
            return FixtureID;
        }

        public void SetFixtureID(int fixtureID)
        {
            FixtureID = fixtureID;
        }

        public int GetAvailableSeats()
        {
            return AvailableSeats;
        }

        public void SetAvailableSeats(int availableSeats)
        {
            AvailableSeats = availableSeats;
        }
        // Method to retrieve available seats
        public static int GetAvailableSeats(string catCode, int fixtureID)
        {
            using (var conn = new OracleConnection(DBConnect.oradb))
            {
                conn.Open();
                string sqlQuery = "SELECT AvailableSeats FROM FixtureSeats WHERE CatCode = :CatCode AND FixtureID = :FixtureID";
                using (var cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(new OracleParameter(":CatCode", catCode));
                    cmd.Parameters.Add(new OracleParameter(":FixtureID", fixtureID));
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }

        // Method to update available seats
        public static void UpdateAvailableSeats(string catCode, int fixtureID, int newAvailableSeats)
        {
            using (var conn = new OracleConnection(DBConnect.oradb))
            {
                conn.Open();
                string sqlQuery = "UPDATE FixtureSeats SET AvailableSeats = :AvailableSeats WHERE CatCode = :CatCode AND FixtureID = :FixtureID";
                using (var cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(new OracleParameter(":AvailableSeats", newAvailableSeats));
                    cmd.Parameters.Add(new OracleParameter(":CatCode", catCode));
                    cmd.Parameters.Add(new OracleParameter(":FixtureID", fixtureID));
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

