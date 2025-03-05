namespace DataContractDeserialization.Data;

using System.Runtime.Serialization;

[DataContract(Namespace = "http://xyz")]
public class Application_SA {
    [DataMember]
    public string Security_Key;
}
