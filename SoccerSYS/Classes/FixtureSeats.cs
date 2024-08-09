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

        // Setter for MaxSeats
        public void SetAvailableSeats(int availableSeats)
        {
            AvailableSeats = availableSeats;
        }
    }
}
