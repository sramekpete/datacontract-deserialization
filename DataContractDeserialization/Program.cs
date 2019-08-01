using DataContractDeserialization.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataContractDeserialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var serializer = new DataContractSerializer(typeof(ApplicationRequestImpl));

            using(var file = File.OpenRead("./Source/Message.xml"))
            {
                using(var xml = XmlReader.Create(file))
                {
                    var result = serializer.ReadObject(xml);
                }
            }            
        }
    }
}
