using System;
using System.Runtime.Serialization;
using Xunit.Sdk;

namespace XunitShould.Sdk
{
    [Serializable]
    internal class EnumerableEqualException : XunitException2
    {
        public EnumerableEqualException(object expected, object actual, int atIndex, int expectedCount, int actualCount)
        {
            Expected = expected?.ToString() ?? "(null)";
            Actual = actual?.ToString() ?? "(null)";
            AtIndex = atIndex;
            ExpectedCount = expectedCount;
            ActualCount = actualCount;
        }

        /// <inheritdoc/>
        protected EnumerableEqualException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            ExpectedCount = info.GetInt32("ExpectedCount");
            ActualCount = info.GetInt32("ActualCount");
            AtIndex = info.GetInt32("AtIndex");
            Expected = info.GetString("Expected");
            Actual = info.GetString("Actual");
        }

        public string Actual { get; }

        public int ActualCount { get; }

        public int AtIndex { get; }

        public string Expected { get; }

        public int ExpectedCount { get; }

        public override string Message =>
            $"Enumerables not equal at index: {AtIndex}{Environment.NewLine}(Expected has {ExpectedCount} items, Actual has {ActualCount} items){Environment.NewLine}Expected:  {Expected}{Environment.NewLine}Actual: {Actual}";

        /// <inheritdoc/>
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
            {
                throw new ArgumentNullException(nameof(info));
            }

            info.AddValue("ExpectedCount", ExpectedCount);
            info.AddValue("ActualCount", ActualCount);
            info.AddValue("AtIndex", AtIndex);
            info.AddValue("Expected", Expected);
            info.AddValue("Actual", Actual);

            base.GetObjectData(info, context);
        }
    }
}