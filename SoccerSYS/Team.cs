using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace SoccerSYS
{
    class Team
    {
        public string TeamID;
        public string TeamName;


        public Team()
        {
            this.TeamID = "";
            this.TeamName = "";
        }
        public Team(string TeamID, string TeamName)
        {
            this.TeamID = TeamID;
            this.TeamName = TeamName;
        }
        public string getTeamID()
        {
            return this.TeamID;
        }
        public string getTeamName()
        {
            return this.TeamName;
        }
        public void setTeamID(string teamID)
        {
            this.TeamID = teamID;
        }
        public void setTeamName(string teamName)
        {
            TeamName = teamName;
        }
        public static List<Team> GetTeams()
        {
            List<Team> teams = new List<Team>();

            // Replace the following lines with actual data retrieval logic.
            teams.Add(new Team { TeamName = "Chelsea" });
            teams.Add(new Team { TeamName = "Manchester United" });
            teams.Add(new Team { TeamName = "Livperpool" });

            return teams;
        }
        public static DataSet GetAllTeams()
        {

            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT TeamID, TeamName " +
                "FROM TEAMS";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "TeamID");

            //Close db connection
            conn.Close();

            return ds;
        }
 
        
    public void AddTeam()
    {
        OracleConnection conn = new OracleConnection(DBConnect.oradb);

        string sqlQuery = "INSERT INTO Teams(TEAMID, TEAMNAME) " +
                          "VALUES (:TeamID, :TeamName)";

        OracleCommand cmd = new OracleCommand(sqlQuery, conn);
        cmd.Parameters.Add(new OracleParameter(":TeamID", this.TeamID));
        cmd.Parameters.Add(new OracleParameter(":TeamName", this.TeamName));
       

        conn.Open();
         cmd.ExecuteNonQuery();
            conn.Close();
    }
        public static DataSet FindTeams(String TeamID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT TeamID, TeamName From Teams " +
                "WHERE TeamID LIKE '%" + TeamID;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);


            OracleDataAdapter da = new OracleDataAdapter(cmd);



            DataSet ds = new DataSet();
            da.Fill(ds, "TeamID");

            conn.Close();

            return ds;

        }
        public void getTeams(String TeamID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT * FROM Teams WHERE TeamID =  " + TeamID;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            setTeamID(dr.GetString(20));
            setTeamName(dr.GetString(25));
           

            conn.Close();


        }
    }
}
