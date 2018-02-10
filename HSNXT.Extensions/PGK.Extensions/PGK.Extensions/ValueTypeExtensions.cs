namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// 	Determines whether the specified value is empty.
        /// </summary>
        /// <typeparam name = "T"></typeparam>
        /// <param name = "value">The value.</param>
        /// <returns>
        /// 	<c>true</c> if the specified value is empty; otherwise, <c>false</c>.
        /// </returns>
        public static bool StructIsEmpty<T>(this T value) where T : struct
        {
            return value.Equals(default(T));
        }

        /// <summary>
        /// 	Determines whether the specified value is not empty.
        /// </summary>
        /// <typeparam name = "T"></typeparam>
        /// <param name = "value">The value.</param>
        /// <returns>
        /// 	<c>true</c> if the specified value is not empty; otherwise, <c>false</c>.
        /// </returns>
        public static bool StructIsNotEmpty<T>(this T value) where T : struct
        {
            return (value.StructIsEmpty() == false);
        }

        /// <summary>
        /// 	Converts the specified value to a corresponding nullable type
        /// </summary>
        /// <typeparam name = "T"></typeparam>
        /// <param name = "value">The value.</param>
        /// <returns>The nullable type</returns>
        public static T? ToNullable<T>(this T value) where T : struct
        {
            return (value.StructIsEmpty() ? null : (T?) value);
        }
    }
}