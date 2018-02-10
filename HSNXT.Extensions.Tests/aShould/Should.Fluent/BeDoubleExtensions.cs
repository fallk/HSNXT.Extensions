using erichexter.Should.Fluent.Model;

namespace erichexter.Should.Fluent
{
    public static class BeDoubleExtensions
    {
        public static double Positive(this IBe<double> be)
        {
            return Check.GreaterThan(be.Should, 0);
        }

        public static double Negative(this IBe<double> be)
        {
            return Check.LessThan(be.Should, 0);
        }
    }
}