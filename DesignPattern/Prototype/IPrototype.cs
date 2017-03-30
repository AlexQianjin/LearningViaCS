using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace Prototype
{
    [Serializable()]
    public abstract class IPrototype<T>
    {
        public T Clone()
        {
            return (T)this.MemberwiseClone();
        }

        public T DeepCopy()
        {
            MemoryStream stream = new MemoryStream();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            xmlSerializer.Serialize(stream, this);
            stream.Seek(0, SeekOrigin.Begin);
            T copy = (T)xmlSerializer.Deserialize(stream);
            stream.Dispose();
            return copy;
        }
    }
}
