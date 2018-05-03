using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroceryPandaService
{
    public class Store
    {
        private string name;
        private string address;
        private List<Product> products;
        private List<User> customers;


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
    }
}