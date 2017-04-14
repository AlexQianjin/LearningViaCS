using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace Memento
{
    [Serializable()]
    public class Memento
    {
        private MemoryStream stream = new MemoryStream();
        private XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<string>));

        public Memento Save(object o)
        {
            xmlSerializer.Serialize(stream, o);
            return this;
        }

        public object Restore()
        {
            stream.Seek(0, SeekOrigin.Begin);
            object o = xmlSerializer.Deserialize(stream);
            stream.Dispose();
            return o;
        }
    }
}
