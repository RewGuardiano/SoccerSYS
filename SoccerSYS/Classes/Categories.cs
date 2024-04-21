using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SoccerSYS
{
    class Categories
    {
        OracleConnection conn = new OracleConnection(DBConnect.oradb);
        internal static int maxSeatsLimit = 500;
        private string CatCode;
        private string Description;
        private decimal Price;
        private int AvailableSeats;
        private int MaxSeats;

        public Categories(string catCode, string description, decimal price, int maxSeats)
        {
            CatCode = catCode;
            Description = description;
            Price = price;
            AvailableSeats = maxSeats;
            MaxSeats = maxSeats;
        }

        // Getter for CatCode
        public string GetCatCode()
        {
            return CatCode;
        }

        // Setter for CatCode
        public void SetCatCode(string catCode)
        {
            CatCode = catCode;
        }

        // Getter for Description
        public string GetDescription()
        {
            return Description;
        }

        // Setter for Description
        public void SetDescription(string description)
        {
            Description = description;
        }

        // Getter for Price
        public decimal GetPrice()
        {
            return Price;
        }

        // Setter for Price
        public void SetPrice(decimal price)
        {
            Price = price;
        }

        // Getter for AvailableSeats
        public int GetAvailableSeats()
        {
            return AvailableSeats;
        }

        // Setter for AvailableSeats
        public void SetAvailableSeats(int availableSeats)
        {
            AvailableSeats = availableSeats;
        }

        // Getter for MaxSeats
        public int GetMaxSeats()
        {
            return MaxSeats;
        }

        // Setter for MaxSeats
        public void SetMaxSeats(int maxSeats)
        {
            MaxSeats = maxSeats;
        }

        public override string ToString()
        {
            return $"Category Code: {CatCode}\nDescription: {Description}\nPrice: {Price:C}\nAvailable Seats: {AvailableSeats}\nMax Seats: {MaxSeats}";
        }
        public static bool ValidateMaxSeatsLimit()
        {
            bool exceedsLimit = false;

            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
                {
                    conn.Open();

                    string query = "SELECT SUM(MaxSeats) AS TotalMaxSeats FROM categories";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            int totalMaxSeats = Convert.ToInt32(result);

                            // Check if the totalMaxSeats exceeds the specified limit
                            if (totalMaxSeats >= maxSeatsLimit)
                            {
                                exceedsLimit = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                // Optionally, handle the exception (e.g., log the error)
            }

            return exceedsLimit;
        }





        public void createCategory()
        {
            // Check if the CatCode already exists in the database
            string checkQuery = "SELECT COUNT(*) FROM CATEGORIES WHERE CATCODE = :CatCode";
            OracleCommand checkCmd = new OracleCommand(checkQuery, conn);
            checkCmd.Parameters.Add(new OracleParameter(":CatCode", this.CatCode));

            conn.Open();
            int count = Convert.ToInt32(checkCmd.ExecuteScalar());
            conn.Close();

            // If the CatCode does not exist, insert a new record
            if (count == 0)
            {
                string sqlQuery = "INSERT INTO CATEGORIES (CATCODE, DESCRIPTION, PRICE, AVAILABLESEATS, MAXSEATS) " +
                                 "VALUES (:CatCode, :Description, :Price, :AvailableSeats, :MaxSeats)";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                cmd.Parameters.Add(new OracleParameter(":Catcode", this.CatCode));
                cmd.Parameters.Add(new OracleParameter(":Description", this.Description));
                cmd.Parameters.Add(new OracleParameter(":Price", this.Price));
                cmd.Parameters.Add(new OracleParameter(":AvailableSeats", this.AvailableSeats));
                cmd.Parameters.Add(new OracleParameter(":MaxSeats", this.MaxSeats));

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                // Display an error message or throw an exception
                MessageBox.Show("Error: The CatCode already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Or, throw an exception
                // throw new Exception("The CatCode already exists.");
            }
        }
        public void updateCategory()
        {
            /*string sqlQuery = "UPDATE CATEGORIES SET " +
                  "DESCRIPTION = :Description, " +
                  "PRICE = :Price, " +
                  "AVAILABLESEATS = :AvailableSeats, " +
                  "MAXSEATS = :MaxSeats " +
                  "WHERE CATCODE = :CatCode";
            */
            string sqlQuery = "UPDATE CATEGORIES SET Description = '" + this.Description + ",Price = " + this.Price + ",AvailableSeats = " +
                this.AvailableSeats + ",MaxSeats = " + this.MaxSeats + " Where CatCode = '" + this.CatCode + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);



            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();


        }

        public static void getCategoryDetails(ref List<string> allCategories)
        {
            allCategories = new List<string>();

            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();

            string sqlQuery = "Select CatCode, Description From Categories";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataReader dr = cmd.ExecuteReader();

           

            while (dr.Read() && !dr.IsDBNull(0))

            {
                string category = $"{dr.GetString(0)} - {dr.GetString(1)}" ;

                allCategories.Add(category);
            
            }
            dr.Close(); 
        }
    }
}

    /*
    public static void getCategoryDetails(ref List<string> allSeatTypes)
    {
        allSeatTypes = new List<string>();
        

        string sqlQuery = "SELECT Type_Code, Description FROM SeatTypes";

        OracleCommand cmd = new OracleCommand(sqlQuery, conn);

        OracleDataReader dr = cmd.ExecuteReader();

        while (dr.Read() && !dr.IsDBNull(0))
        {
            string seatType = $"{dr.GetString(0)} - {dr.GetString(1)}";

            allSeatTypes.Add(seatType);
        }

        dr.Close();
    }*/
    /*
    public static char[] getAllCatCode()
    {
        string sqlQuery = "Select Catcode FROM Categories ";

        //OracleCommand 

    }*/
    /*
    public static DataSet GetAllCategories()
        {

            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT CatCode, description,Price,NoSeats " +
                "FROM CATEGORYS ORDER BY CatCode";

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

            String sqlQuery = "SELECT * FROM CATEGORYS WHERE Catcode =  " + CatCode;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            setCatCode(dr.GetString(1));
            setdescription(dr.GetString(25));
            setprice(dr.GetDecimal(5));
            setNoSeats(dr.GetInt32(4));
            setSeatFrom(dr.GetInt32(4));
            setSeatTo(dr.GetInt32(4));

            conn.Close();
            

        }
       public void SetCategory()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            string sqlQuery = "INSERT INTO CATEGORYS (TICKETID, CATCODE, DESCRIPTION, PRICE, NOSEATS, SEATFROM, SEATTO,Status) " +
                              "VALUES (:ticketID, :catCode, :description, :price, :noSeats, :seatFrom, :seatTo,:status)";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.Parameters.Add(new OracleParameter(":ticketID", this.TicketID));
            cmd.Parameters.Add(new OracleParameter(":catCode", this.CatCode));
            cmd.Parameters.Add(new OracleParameter(":description", this.description));
            cmd.Parameters.Add(new OracleParameter(":price", this.Price));
            cmd.Parameters.Add(new OracleParameter(":noSeats", this.NoSeats));
            cmd.Parameters.Add(new OracleParameter(":seatFrom", this.SeatFrom));
            cmd.Parameters.Add(new OracleParameter(":seatTo", this.SeatTo));
            cmd.Parameters.Add(new OracleParameter(":status", this.Status));

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
     

        public void UpdateCategory()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string sqlQuery = "UPDATE CATEGORYS SET " +
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

            String sqlQuery = "SELECT TicketID,CatCode,Description,Price,NoSeats,SeatFrom,SeatTo,Status From CATEGORYS " +
                "WHERE Catcode LIKE '%" + CatCode + "%' ORDER BY Catcode";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);


            OracleDataAdapter da = new OracleDataAdapter(cmd);



            DataSet ds = new DataSet();
            da.Fill(ds, "Cat");

            conn.Close();

            return ds;
   
        }
   */




  