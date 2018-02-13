using System;

namespace erichexter.Should.Fluent.Model
{
    public class ShouldBase<T, TTarget, TBe> : IShould<TTarget> where T : ShouldBase<T, TTarget, TBe>
    {
        protected readonly IAssertProvider assertProvider;
        internal TTarget Target;
        internal bool Negate;

        public ShouldBase(TTarget target, IAssertProvider assertProvider)
        {
            this.assertProvider = assertProvider;
            this.Target = target;
        }

        public T Not
        {
            get
            {
                Negate = !Negate;
                return (T) this;
            }
        }

        public TBe Be
        {
            get { return (TBe) Activator.CreateInstance(typeof(TBe), this); }
        }

        public TTarget Equal(TTarget expected)
        {
            return ((IShould<TTarget>) this).Apply(
                (t, a) => a.AreEqual(expected, t),
                (t, a) => a.AreNotEqual(expected, Target));
        }

        TTarget IShould<TTarget>.Apply(Action<TTarget, IAssertProvider> positiveCase,
            Action<TTarget, IAssertProvider> negativeCase)
        {
            if (Negate)
            {
                negativeCase(Target, assertProvider);
            }
            else
            {
                positiveCase(Target, assertProvider);
            }

            return Target;
        }

        object IShould<TTarget>.Apply(Func<TTarget, IAssertProvider, object> positiveCase,
            Func<TTarget, IAssertProvider, object> negativeCase)
        {
            return Negate
                ? negativeCase(Target, assertProvider)
                : positiveCase(Target, assertProvider);
        }

        public TTarget Apply(Action<TTarget, IAssertProvider, bool> action)
        {
            action(Target, assertProvider, Negate);
            return Target;
        }
    }
}