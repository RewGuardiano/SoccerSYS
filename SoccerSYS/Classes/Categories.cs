﻿using System;
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
        private int MaxSeats;

        public Categories(string catCode, string description, decimal price, int maxSeats)
        {
            CatCode = catCode;
            Description = description;
            Price = price;
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
            return $"Category Code: {CatCode}\nDescription: {Description}\nPrice: {Price:C}\nMax Seats: {MaxSeats}";
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
                string sqlQuery = "INSERT INTO CATEGORIES (CATCODE, DESCRIPTION, PRICE, MAXSEATS) " +
                                 "VALUES (:CatCode, :Description, :Price, :MaxSeats)";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                cmd.Parameters.Add(new OracleParameter(":Catcode", this.CatCode));
                cmd.Parameters.Add(new OracleParameter(":Description", this.Description));
                cmd.Parameters.Add(new OracleParameter(":Price", this.Price));
                cmd.Parameters.Add(new OracleParameter(":MaxSeats", this.MaxSeats));

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                // Display an error message or throw an exception
                MessageBox.Show("Error: The CatCode already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // throw new Exception("The CatCode already exists.");
            }
        }
        public void updateCategory()
        {

            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
                {
                    string sqlQuery = "UPDATE CATEGORIES SET Description = :description, Price = :price, MaxSeats = :maxSeats WHERE CatCode = :catCode";

                    using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                    {
                        
                        cmd.Parameters.Add(new OracleParameter(":description", this.Description));
                        cmd.Parameters.Add(new OracleParameter(":price", this.Price));
                        cmd.Parameters.Add(new OracleParameter(":maxSeats", this.MaxSeats));
                        cmd.Parameters.Add(new OracleParameter(":catCode", this.CatCode));

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating category: " + ex.Message);
                
            }
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

        
        public static decimal getCategoryPrice(string CatCode)
        {
            decimal price = 0;
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();

            string sqlQuery = $"SELECT Price FROM CATEGORIES Where CatCode = '{CatCode}'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataReader dr = cmd.ExecuteReader();


            while (dr.Read() && !dr.IsDBNull(0))
            {
                price += dr.GetInt32(0);

            }


            conn.Close();
            return price;
        }


    }
}

   
   




  