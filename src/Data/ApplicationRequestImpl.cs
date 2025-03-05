namespace DataContractDeserialization.Data;

using System.Runtime.Serialization;

[DataContract(Namespace = "http://xyz")]
public class ApplicationRequestImpl {
    [DataMember]
    public Application Application;

    [DataMember]
    public Application_SA[] Application_SAList;
}
