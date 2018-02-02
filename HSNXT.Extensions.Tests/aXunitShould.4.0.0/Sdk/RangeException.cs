using System;
using System.Runtime.Serialization;
using Xunit.Sdk;

namespace XunitShould.Sdk
{
    internal abstract class RangeException : XunitException2
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="RangeException" /> class.
        /// </summary>
        /// <param name="actual">The actual.</param>
        /// <param name="low">The low.</param>
        /// <param name="lowInclusive">
        ///     if set to <c>true</c> low is considered in the range.
        /// </param>
        /// <param name="high">The high.</param>
        /// <param name="highInclusive">
        ///     if set to <c>true</c> high is considered in the range.
        /// </param>
        /// <param name="messageHeader">exception message header</param>
        /// <remarks></remarks>
        protected RangeException(object actual, object low, bool lowInclusive, object high, bool highInclusive,
            string messageHeader)
            : base(messageHeader)
        {
            Actual = actual == null ? null : actual.ToString();
            Low = low == null ? null : low.ToString();
            LowInclusive = lowInclusive;
            High = high == null ? null : high.ToString();
            HighInclusive = highInclusive;
        }

        /// <inheritdoc/>
        protected RangeException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            Actual = info.GetString("Actual");
            Low = info.GetString("Low");
            LowInclusive = info.GetBoolean("LowInclusive");
            High = info.GetString("High");
            HighInclusive = info.GetBoolean("HighInclusive");
        }

        /// <summary>
        ///     Gets the actual object value
        /// </summary>
        public string Actual { get; }

        /// <summary>
        ///     Gets the high value of the range
        /// </summary>
        public string High { get; }

        /// <summary>
        ///     Gets a value indicating whether high is considered in the range.
        /// </summary>
        /// <remarks></remarks>
        public bool HighInclusive { get; }

        /// <summary>
        ///     Gets the low value of the range
        /// </summary>
        public string Low { get; }

        /// <summary>
        ///     Gets a value indicating whether low is considered in the range.
        /// </summary>
        /// <remarks></remarks>
        public bool LowInclusive { get; }

        /// <inheritdoc/>
        public override string Message => string.Format("{0}{6}Range:  {1}{2} - {3}{4}{6}Actual: {5}",
            base.Message,
            LowInclusive ? "[" : "(",
            Low,
            High,
            HighInclusive ? "]" : ")",
            Actual ?? "(null)",
            Environment.NewLine);

        /// <inheritdoc/>
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
            {
                throw new ArgumentNullException(nameof(info));
            }

            info.AddValue("Actual", Actual);
            info.AddValue("Low", Low);
            info.AddValue("LowInclusive", LowInclusive);
            info.AddValue("High", High);
            info.AddValue("HighInclusive", HighInclusive);

            base.GetObjectData(info, context);
        }
    }
}