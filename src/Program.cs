namespace DataContractDeserialization;

using DataContractDeserialization.Data;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;

class Program {
    static void Main(string[] _) {
        var serializer = new DataContractSerializer(typeof(ApplicationRequestImpl));

        using (var file = File.OpenRead("./Message.xml")) {
            using (var xml = XmlReader.Create(file)) {
                ApplicationRequestImpl result = (ApplicationRequestImpl)serializer.ReadObject(xml);

                Console.WriteLine($"Amount is {result.Application.Amount}.");

                for (int i = 0; i < result.Application_SAList.Length; i++) {
                    Console.WriteLine($"Security key at position {i} is {result.Application_SAList[i].Security_Key}.");
                }
            }
        }

        Console.ReadKey();
    }
}
