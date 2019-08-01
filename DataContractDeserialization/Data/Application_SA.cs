using System.Runtime.Serialization;

namespace DataContractDeserialization.Data
{
    [DataContract(Namespace = "http://xyz")]
    public class Application_SA
    {
        [DataMember]
        public string Security_Key;
    }
}
