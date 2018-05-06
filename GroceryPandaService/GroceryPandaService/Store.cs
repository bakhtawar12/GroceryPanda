using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace GroceryPandaService
{
    [DataContract]
    public class Store
    {
        
        string name;
        string address;
        List<Product> products=new List<Product>();
        List<User> customers=new List<User>();

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
        public List<Product> Products
        {
            get
            {
                return products;
            }

            set
            {
                products = value;
            }
        }
        [DataMember]
        public List<User> Customers
        {
            get
            {
                return customers;
            }

            set
            {
                customers = value;
            }
        }
        [DataMember]
        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }
        public void addproduct(Product p)
        { 
            if(Products==null)
            {
                Products = new List<Product>();
            }
            Products.Add(p);
        }
    }
}