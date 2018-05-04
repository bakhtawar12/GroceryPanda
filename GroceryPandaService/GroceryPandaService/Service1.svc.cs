using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GroceryPandaService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public bool adminChangePassword(string question, string answer, string newPass)
        {
            if(AdminDL.Admin.Question == question && AdminDL.Admin.Answer == answer)
            {
                AdminDL.Admin.Password = newPass;
                return true;
            }
            return false;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public bool isValidAdmin(string name, string password)
        {
            if(AdminDL.Admin.Username == name && AdminDL.Admin.Password == password)
            {
                return true;
            }
            return false;
        }

        public bool RegisterAdmin(string username, string passwrod, string contact, string question, string answer)
        {
            if(AdminDL.Admin.Username == null)
            {
                AdminDL.Admin.Username = username;
                AdminDL.Admin.Password = passwrod;
                AdminDL.Admin.Contact_no = contact;
                AdminDL.Admin.Question = question;
                AdminDL.Admin.Answer = answer;
                return true;
            }
            return false;
        }

        public bool registerUser(string username, string passwrod, string contact, string question, string answer)
        {
            foreach(User u in UserDL.Users)
            {
                if(u.Username == username)
                {
                    return false;
                }
            }
            User user = new User();
            user.Username = username;
            user.Password = passwrod;
            user.Contact_no = contact;
            user.Question = question;
            user.Answer = answer;
            UserDL.Users.Add(user);
            return true;
        }

        public bool userChangePassword(string username, string question, string answer, string newPass)
        {
            foreach(User u in UserDL.Users)
            {
                if(u.Username == username)
                {
                    if(u.Question == question && u.Answer == answer)
                    {
                        u.Password = newPass;
                        return true;
                    }
                }
            }
            return false;
        }

        public bool validUser(string username, string password)
        {
           foreach(User u in UserDL.Users)
            {
                if(u.Username == username && u.Password == password)
                {
                    UserDL.Current_user = u;
                    return true;
                }
            }
            return false;
        }
    }
}
