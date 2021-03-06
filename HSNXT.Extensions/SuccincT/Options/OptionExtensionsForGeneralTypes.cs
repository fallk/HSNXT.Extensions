﻿namespace HSNXT.SuccincT.Options
{
    public static class OptionExtensionsForGeneralTypes
    {
        public static Option<T> ToOption<T>(this T obj) =>
            obj != null ? obj : Option<T>.None();

        public static T? AsNullable<T>(this Option<T> option) where T : struct =>
            option.HasValue ? option.Value : (T?) null;

        public static Option<T> TryCast<T>(this object value) where T : class =>
            (value as T).ToOption();
    }
}