namespace DataContractDeserialization;

using DataContractDeserialization.Data;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;

class Program {
    static void Main(string[] _) {
        var serializer = new DataContractSerializer(typeof(ApplicationRequestImpl));

        using (var file = File.OpenRead("./Message.xml")) {
            using (var xml = XmlReader.Create(file)) {
                var result = serializer.ReadObject(xml);
            }
        }
    }
}
