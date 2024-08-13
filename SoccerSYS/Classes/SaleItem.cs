using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace SoccerSYS.Classes
{
    class SaleItem
    {
        private int SaleItem_ID;
        private int SaleID;
        private string CatCode;
        private int Quantity;
        private int Total_Price;
        private char Is_Cancel;
        private OracleCommand cmd;
        private OracleConnection conn = new OracleConnection(DBConnect.oradb);
        private OracleDataReader dr;
        public SaleItem(int saleID, string catCode, int quantity, int total_Price, char is_Cancel)
        {
            SaleItem_ID = getPreviousSaleItem_ID() + 1;
            this.SaleID = saleID;
            this.CatCode = catCode;
            Quantity = quantity;
            Total_Price = total_Price;
            Is_Cancel = is_Cancel;
        }
        public int GetSaleItemID()
        {
            return SaleItem_ID;
        }

        // Setter for SaleItem_ID
        public void SetSaleItemID(int saleItemID)
        {
            SaleItem_ID = saleItemID;
        }

        // Getter for saleID
        public int GetSaleID()
        {
            return SaleID;
        }

        // Setter for saleID
        public void SetSaleID(int saleID)
        {
            this.SaleID = saleID;
        }

        // Getter for catCode
        public string GetCatCode()
        {
            return CatCode;
        }

        // Setter for catCode
        public void SetCatCode(string catCode)
        {
            this.CatCode = catCode;
        }

        // Getter for Quantity
        public int GetQuantity()
        {
            return Quantity;
        }

        // Setter for Quantity
        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }

        // Getter for Total_Price
        public int GetTotalPrice()
        {
            return Total_Price;
        }

        // Setter for Total_Price
        public void SetTotalPrice(int totalPrice)
        {
            Total_Price = totalPrice;
        }

        public char GetIsCancel()
        {
            return Is_Cancel;
        }

        public void SetIsCancel(char isCancel)
        {
            Is_Cancel = isCancel;
        }
        private int getPreviousSaleItem_ID()
        {
            string sqlquery = "SELECT MAX (SaleItem_ID) From SaleItems";

            cmd = new OracleCommand(sqlquery, conn);

            conn.Open();

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
        public void addSaleItem()
        {

            string sqlQuery = "INSERT INTO SaleItems (SaleItem_ID,SaleID,CatCode,Quantity,Total_Price,Is_Cancel) " +
                    "VALUES (:SaleItem_ID, :SaleID, :CatCode, :Quantity, :Total_Price, :Is_Cancel)";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.Parameters.Add(new OracleParameter(":SaleItem_ID", this.SaleItem_ID));
            cmd.Parameters.Add(new OracleParameter(":SaleID", this.SaleID));
            cmd.Parameters.Add(new OracleParameter(":CatCode", this.CatCode));
            cmd.Parameters.Add(new OracleParameter(":Quantity", this.Quantity));
            cmd.Parameters.Add(new OracleParameter(":Total_Price", this.Total_Price));
            cmd.Parameters.Add(new OracleParameter(":Is_Cancel", this.Is_Cancel));

            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
