using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Collections;

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
        public void addstore(Store sto)
        {
            StoreDL.Stores.Add(sto);
        }

        public List<Store> shoowstores()
        {
            return StoreDL.Stores;
        }

        public void addStoreProducts(Store s,string name,int price1,int quantity1)
        {
            Product p = new Product();
            p.Name = name;
            p.Price = price1;
            p.Quantity = quantity1;
            foreach(Store sto in StoreDL.Stores)
            {
                if(sto.Name==s.Name && sto.Address == s.Address)
                {
                    sto.addproduct(p);
                }
            }
        }
        public void deleteStore(Store s)
        {
            int p = 0;
            foreach (Store sto in StoreDL.Stores)
            {
                if (sto.Name == s.Name && sto.Address == s.Address)
                {
                    p = StoreDL.Stores.IndexOf(sto);
                }
            }

            StoreDL.Stores.RemoveAt(p);
            
        }
        public Store getstore(int index)
        {
            return StoreDL.Stores[index];
        }
        public void getproduct(String s,Product pro)
        {
            int p = 0;
            foreach(Store sto in StoreDL.Stores)
            {
                if(sto.Name == s)
                {
                    foreach(Product pi in sto.Products)
                    {
                        if (pi == pro)
                        {
                            p = sto.Products.IndexOf(pi);
                            break;
                        }
                    }
                    sto.Products.RemoveAt(p);
                }
            }
        }

        public List<Product> getStoreProducts(string store_name)
        {
            List<Product> products = new List<Product>();
            foreach(Store s in StoreDL.Stores)
            {
                if(s.Name == store_name)
                {
                    products = s.Products;
                }
            }
            return products;
        }

        public Product getProduct(string store_name, int index)
        {
            return getStoreProducts(store_name)[index];
        }

        public void orderProduct(Product p)
        {
            UserDL.Current_user.Order_list.Add(p);
        }

        public string getPrice()
        {
            int price = 0;
            foreach(Product p in UserDL.Current_user.Order_list)
            {
                price += p.Price;
            }
            return price.ToString();
        }

        public List<Product> getOrderList()
        {
            return UserDL.Current_user.Order_list;
        }

        public void addCustomerToStore(string store_name)
        {
            foreach(Store s in StoreDL.Stores)
            {
                if(s.Name == store_name)
                {
                    if(s.Customers == null)
                    {
                        s.Customers = new List<User>();
                    }
                    s.Customers.Add(UserDL.Current_user);
                }
            }
        }

        public void clearCustomer(string store_name, string customer_name)
        {
            int i = 0;
            foreach(Store s in StoreDL.Stores)
            {
                if(s.Name == store_name)
                {
                    i = 0;
                    foreach(User u in s.Customers)
                    {
                        if (u.Username == customer_name) {
                            u.Order_list.Clear();
                            break;
                        }
                        i++;
                    }
                }
                if (s.Customers != null)
                {
                    s.Customers.RemoveAt(i);
                }
            }
        }
    }
}
