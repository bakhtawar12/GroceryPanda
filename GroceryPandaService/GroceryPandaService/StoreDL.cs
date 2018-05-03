using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroceryPandaService
{
    public class StoreDL
    {
        private static List<Store> stores = new List<Store>();

        public static List<Store> Stores
        {
            get
            {
                return stores;
            }

            set
            {
                stores = value;
            }
        }
    }
}