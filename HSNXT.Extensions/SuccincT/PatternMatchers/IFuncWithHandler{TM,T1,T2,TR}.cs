using System;
using HSNXT.SuccincT.Unions;

namespace HSNXT.SuccincT.PatternMatchers
{
    public interface IFuncWithHandler<out TMatcher, T1, T2, in TResult>
    {
        IFuncWithHandler<TMatcher, T1, T2, TResult> Or(Either<T1, Any> value1, Either<T2, Any> value2);

        TMatcher Do(Func<T1, T2, TResult> function);

        TMatcher Do(TResult value);
    }
}