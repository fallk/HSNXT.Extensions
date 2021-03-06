using System;
using HSNXT.SuccincT.Unions;

namespace HSNXT.SuccincT.PatternMatchers
{
    public interface IMatcher<T1, T2, T3>
    {
        IActionWithHandler<IActionMatcher<T1, T2, T3>, T1, T2, T3> With(Either<T1, Any> value1,
            Either<T2, Any> value2,
            Either<T3, Any> value3);

        IActionWhereHandler<IActionMatcher<T1, T2, T3>, T1, T2, T3> Where(Func<T1, T2, T3, bool> function);
        IFuncMatcher<T1, T2, T3, TR> To<TR>();
    }
}