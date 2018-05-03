using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroceryPandaService
{
    public class UserDL
    {
        private static List<User> users = new List<User>();

        public static List<User> Users
        {
            get
            {
                return users;
            }

            set
            {
                users = value;
            }
        }
    }
}