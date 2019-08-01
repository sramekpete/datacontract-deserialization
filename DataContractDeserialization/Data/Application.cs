using System.Runtime.Serialization;

namespace DataContractDeserialization.Data
{
    [DataContract(Namespace = "http://xyz")]
    public class Application
    {

        [DataMember]
        public string Amount;
    }
}
