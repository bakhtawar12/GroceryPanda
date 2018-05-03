using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroceryPandaService
{
    public class AdminDL
    {
        private static Admin _admin = new Admin();

        public static Admin Admin
        {
            get
            {
                return _admin;
            }

            set
            {
                _admin = value;
            }
        }
    }
}