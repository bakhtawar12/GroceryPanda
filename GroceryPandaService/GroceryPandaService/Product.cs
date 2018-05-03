using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroceryPandaService
{
    public class Product
    {
        private string name;
        private int price; 
        private int quantity;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }
    }
}