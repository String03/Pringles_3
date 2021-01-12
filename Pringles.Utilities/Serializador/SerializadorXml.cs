using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pringles.Utilities.Serializador
{
    public static class SerializadorXml
    {
        public static string CrearXml<T>(T texto)
        {
            XmlSerializer s = new XmlSerializer(typeof(T));
            MemoryStream ms = new MemoryStream();
            s.Serialize(ms, texto);
            return Encoding.ASCII.GetString(ms.ToArray());
        }

        public static T LeerXml<T>(string xml)
        {
            TextReader reader = new StringReader(xml);
            XmlSerializer s = new XmlSerializer(typeof(T));
            return (T)s.Deserialize(reader);
        }
    }
}
