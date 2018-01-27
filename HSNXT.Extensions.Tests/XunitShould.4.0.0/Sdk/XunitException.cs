using System.Runtime.Serialization;
using NUnit.Framework;

namespace Xunit.Sdk
{
    internal class XunitException2 : AssertionException
    {
        public XunitException2() : base("No msg")
        {
        }

        public XunitException2(string message)
            : base(message)
        {
        }

        protected XunitException2(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}