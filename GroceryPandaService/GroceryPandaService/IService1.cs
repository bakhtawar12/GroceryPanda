using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GroceryPandaService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        bool RegisterAdmin(string username, string passwrod, string contact, string question, string answer);

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        bool isValidAdmin(string name, string password);

        [OperationContract]
        bool adminChangePassword(string question, string answer, string newPass);

        [OperationContract]
        bool registerUser(string username, string passwrod, string contact, string question, string answer);

        [OperationContract]
        bool validUser(string username, string password);

        [OperationContract]
        bool userChangePassword(string username, string question, string answer, string newPass);

        [OperationContract]

        void addstore(Store sto);


        [OperationContract]

        List<Store> shoowstores();

        [OperationContract]

        void addStoreProducts(Store s, string name, int price1, int quantity1);

        [OperationContract]

        void deleteStore(Store s );

        [OperationContract]

        Store getstore(int index);


        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
