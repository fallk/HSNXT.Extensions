namespace erichexter.Should.Fluent.Model
{
    public class BeDouble
    {
        private readonly ShouldDouble should;
        private readonly IAssertProvider assertProvider;

        public BeDouble(ShouldDouble should, IAssertProvider assertProvider)
        {
            this.should = should;
            this.assertProvider = assertProvider;
        }

        public double Positive()
        {
            if (should.Negate)
            {
                assertProvider.LessThanOrEqual(0, should.Target);
            }
            else
            {
                assertProvider.GreaterThan(0, should.Target);
            }

            return should.Target;
        }

        public double Negative()
        {
            if (should.Negate)
            {
                assertProvider.GreaterThanOrEqual(0, should.Target);
            }
            else
            {
                assertProvider.LessThan(0, should.Target);
            }

            return should.Target;
        }
    }
}