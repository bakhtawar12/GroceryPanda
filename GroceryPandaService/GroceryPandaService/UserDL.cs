using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroceryPandaService
{
    public class UserDL
    {
        private static List<User> users = new List<User>();
        private static User current_user = new User();

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

        public static User Current_user
        {
            get
            {
                return current_user;
            }

            set
            {
                current_user = value;
            }
        }
    }
}