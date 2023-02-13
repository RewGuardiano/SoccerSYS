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
        private string CatCode;
        private string description;
        private decimal Price;
        private int NoSeats;
        private int SeatFrom;
        private int SeatTo;


        public Category()
        {
            this.CatCode = "";
            this.description = "";
            this.Price = 0;
            this.NoSeats = 0;
            this.SeatFrom = 0;
            this.SeatTo = 0;

        }
        public Category(string CatCode, string description, decimal price, int Noseats, int SeatFrom, int SeatTo)
        {
            this.CatCode = CatCode;
            this.description = description;
            this.Price = price;
            this.NoSeats = NoSeats;
            this.SeatFrom = SeatFrom;
            this.SeatTo = SeatTo;
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
        public void setCatCode(string CatCode)
        {
            CatCode = CatCode;

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

        public void getCategory(int id)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT * FROM Category WHERE CategoryID =  " + id;

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

            String sqlQuery = "INSERT INTO CATEGORY Values (" +
                this.CatCode + "','" +
                this.description + "','" +
                this.Price + "','" +
                this.NoSeats + "','" +
                this.SeatFrom + "','" +
                this.SeatTo + "')";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public void UpdateCategory()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "Update Category Ticket " +
                "CategoryCode = " + this.CatCode + "," +
                "Description = " + this.description + "," +
                "Price = " + this.Price + "," +
                "NoSeats = " + this.NoSeats + "," +
                "NoSeatFrom = " + this.SeatFrom + "," +
                "NoSeatTo = " + this.SeatTo + " " +
                "Where CategoryCode = " + this.CatCode;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static DataSet findCategory(String CatType)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT CatCode,description,Price From Categories " +
                "WHERE description LIKE '%" + CatType + "%' ORDER BY Description";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);


            OracleDataAdapter da = new OracleDataAdapter(cmd);



            DataSet ds = new DataSet();
            da.Fill(ds, "Cat");

            conn.Close();

            return ds;
   
        }
    }
}
