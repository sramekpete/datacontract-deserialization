namespace DataContractDeserialization.Data;

using System.Runtime.Serialization;

[DataContract(Namespace = "http://xyz")]
public class Application {
    [DataMember]
    public string Amount;
}
