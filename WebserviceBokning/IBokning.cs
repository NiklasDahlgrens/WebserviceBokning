using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebserviceBokning
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IBokning
    {

        [OperationContract]
        string GetData(int value);

        
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Niklas är ful och äcklig och gillar killar
        // Niklas gillar bajs
    }


  
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "HASSssdasda sdasda";

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
