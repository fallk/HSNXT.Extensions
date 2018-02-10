using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Xunit;
using Assert = erichexter.Should.Core.Assertions.Assert;

namespace erichexter.Should.Facts.Core
{
    public class SerializationTests
    {
        [Serializable]
        class SerializableObject { }

        [Fact]
        void CanSerializeAndDeserializeObjectsInATest()
        {
            BinaryFormatter bf = new BinaryFormatter();

            using (Stream ms = new MemoryStream())
            {
                bf.Serialize(ms, new SerializableObject());
                ms.Position = 0;
                object o = bf.Deserialize(ms);

                Should.Core.Assertions.Assert.IsType(typeof(SerializableObject), o);
                Should.Core.Assertions.Assert.DoesNotThrow(delegate { SerializableObject o2 = (SerializableObject)o; });
            }
        }
    }
}