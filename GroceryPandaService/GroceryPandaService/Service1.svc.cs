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
    }
}
