using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace GroceryPandaService
{
    [DataContract]
    public class Product
    {
        string name;
        int price; 
        int quantity;
        [DataMember]
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
        [DataMember]
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
        [DataMember]
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