using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroceryPandaService
{
    public class User : Person
    {
        private List<Product> order_list;

        public List<Product> Order_list
        {
            get
            {
                return order_list;
            }

            set
            {
                order_list = value;
            }
        }
    }
}