using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerSYS.Classes
{
    class AwayTeam
    {
        private char awayTeam_ID;
        private string TeamName;

        public AwayTeam(char awayTeam_ID, string teamName)
        {
            this.awayTeam_ID = awayTeam_ID;
            TeamName = teamName;
        }

        public char GetAwayTeamID()
        {
            return awayTeam_ID;
        }

        // Setter for awayTeam_ID
        public void SetAwayTeamID(char awayTeamID)
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
    }
}
