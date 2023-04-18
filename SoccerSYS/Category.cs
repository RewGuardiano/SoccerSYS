using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;


namespace SoccerSYS
{
    class Category
    {
        private int TicketID;
        private string CatCode;
        private string description;
        private decimal Price;
        private int NoSeats;
        private int SeatFrom;
        private int SeatTo;
        private char Status;

        


        public Category()
        {
            this.TicketID = 0;
            this.CatCode = "";
            this.description = "";
            this.Price = 0;
            this.NoSeats = 0;
            this.SeatFrom = 0;
            this.SeatTo = 0;
            this.Status = ' ' ;


        }
        public Category(int TicketID,string CatCode, string description, decimal price, int NoSeats, int SeatFrom, int SeatTo, char Status)
        {
        
            this.CatCode = CatCode;
            this.description = description;
            this.Price = price;
            this.NoSeats = NoSeats;
            this.SeatFrom = SeatFrom;
            this.SeatTo = SeatTo;
            this.Status = Status;

        }
        public int getTicketID()
        {
            return this.TicketID;
        }
        public string getCatCode()
        {
            return this.CatCode;

        }
        public string getdescription()
        {
            return this.description;
        }
        public decimal getprice()
        {
            return this.Price;
        }
        public int getNoSeats()
        {
            return this.NoSeats;

        }
        public int getSeatFrom()
        {
            return this.SeatFrom;
        }
        public int getSeatTo()
        {
            return this.SeatTo;
        }
        public char getStatus()
        {
            return this.Status;
        }
        public void setTicketID(int TicketID)
        {
            this.TicketID = TicketID;
        }
        public void setCatCode(string CatCode)
        {
            this.CatCode = CatCode;

        }
        public void setdescription(string Description)
        {
            description = Description;
        }
        public void setprice(decimal price)
        {
            Price = price;
        }
        public void setNoSeats(int noSeats)
        {
            NoSeats= noSeats;

        }
        public void setSeatFrom(int seatFrom)
        {
            SeatFrom = seatFrom;
        }
        public void setSeatTo(int seatTo)
        {
            SeatTo = seatTo;
        }
        public void setStatus(char status)
        {
            Status = status;
        }


        private int GenerateNewTicketID()
        {
            // Connect to the database
            OracleConnection connection = new OracleConnection(DBConnect.oradb);
            connection.Open();

            // Query for the current maximum TicketID value
            OracleCommand command = new OracleCommand("SELECT MAX(TicketID) FROM Categories", connection);
            int maxTicketID = (int)command.ExecuteScalar();

            // Generate a new TicketID by adding 1 to the current maximum value
            int newTicketID = maxTicketID + 1;

            // Close the database connection
            connection.Close();

            // Return the new TicketID
            return newTicketID;
        }
        



        public static DataSet GetAllCategories()
        {

            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT CatCode, description,Price,NoSeats " +
                "FROM CATEGORIES ORDER BY CatCode";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Cat");

            //Close db connection
            conn.Close();

            return ds;
        }


        public void getCategory(String CatCode)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT * FROM CATEGORIES WHERE Catcode =  " + CatCode;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            setCatCode(dr.GetString(1));
            setdescription(dr.GetString(20));
            setprice(dr.GetDecimal(5));
            setNoSeats(dr.GetInt32(4));
            setSeatFrom(dr.GetInt32(4));
            setSeatTo(dr.GetInt32(4));

            conn.Close();
            

        }

        public void SetCategory()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "INSERT INTO CATEGORIES Values ('" +
                this.CatCode + "','" +
                this.description + "'," +
                this.Price + "," +
                this.NoSeats + "," +
                this.SeatFrom + "," +
                this.SeatTo + ")";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();

            // Generate a new TicketID
            int newTicketID = GenerateNewTicketID();

            // Create a new ticket object
            Category newTicket = new Category();
            newTicket.TicketID = newTicketID;
            // set other properties of the ticket here

            // Insert the new ticket into the database
            OracleConnection connection = new OracleConnection(DBConnect.);
            connection.Open();
            OracleCommand command = new OracleCommand("INSERT INTO Categories (TicketID, ...) VALUES (@TicketID, ...)", connection);

            command.Parameters.Add("TicketID", newTicket.TicketID);
            // set other parameters for the SQL command here
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void UpdateCategory()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string sqlQuery = "UPDATE CATEGORIES SET " +
                              "description = :description," +
                              "Price = :Price," +
                              "NoSeats = :NoSeats," +
                              "SeatFrom = :SeatFrom," +
                              "SeatTo = :SeatTo " + 
                              "WHERE CatCode = :Catcode"; 

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
   
            cmd.Parameters.Add(new OracleParameter(":description", description));
            cmd.Parameters.Add(new OracleParameter(":Price",Price));
            cmd.Parameters.Add(new OracleParameter(":NoSeats",NoSeats)); 
            cmd.Parameters.Add(new OracleParameter(":SeatFrom", SeatFrom));
            cmd.Parameters.Add(new OracleParameter(":SeatTo",SeatTo));
            cmd.Parameters.Add(new OracleParameter(":CatCode", CatCode));

            cmd.ExecuteNonQuery();

            conn.Close();
        }


        public static DataSet FindCategory(String CatCode)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT CatCode,Description,Price,NoSeats,SeatFrom,SeatTo From Categories " +
                "WHERE Catcode LIKE '%" + CatCode + "%' ORDER BY Catcode";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);


            OracleDataAdapter da = new OracleDataAdapter(cmd);



            DataSet ds = new DataSet();
            da.Fill(ds, "Cat");

            conn.Close();

            return ds;
   
        }
        public void RemoveCategory()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
        

            string sqlQuery = "DELETE FROM CATEGORIES WHERE CatCode = :CatCode";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.Parameters.Add(new OracleParameter(":CatCode", CatCode));

            cmd.ExecuteNonQuery();

            conn.Close();


        }
    }
}
