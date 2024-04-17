using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerSYS.Classes
{
    class SaleItem
    {
        private int SaleItem_ID;
        private int saleID;
        private char catCode;
        private int Quantity;
        private Decimal Total_Price;

        public SaleItem(int saleItem_ID, int saleID, char catCode, int quantity, decimal total_Price)
        {
            SaleItem_ID = saleItem_ID;
            this.saleID = saleID;
            this.catCode = catCode;
            Quantity = quantity;
            Total_Price = total_Price;
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
            return saleID;
        }

        // Setter for saleID
        public void SetSaleID(int saleID)
        {
            this.saleID = saleID;
        }

        // Getter for catCode
        public char GetCatCode()
        {
            return catCode;
        }

        // Setter for catCode
        public void SetCatCode(char catCode)
        {
            this.catCode = catCode;
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
        public decimal GetTotalPrice()
        {
            return Total_Price;
        }

        // Setter for Total_Price
        public void SetTotalPrice(decimal totalPrice)
        {
            Total_Price = totalPrice;
        }

    }
}
