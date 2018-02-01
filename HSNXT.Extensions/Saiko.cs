using System.Globalization;
using System.Linq;
using System.Net;

namespace HSNXT
{
    // Extension methods by NaamloosDT, from https://github.com/NaamloosDT/Saiko
    public static partial class Extensions
    {
        /// <summary>
        /// Returns a new string in which all the characters in the current instance, beginning at a specified position
        /// and continuing through the last position, have been deleted. If the specified position is out of bounds,
        /// returns an unmodified string.</summary>
        /// <param name="input">The string</param>
        /// <param name="index">The zero-based position to begin deleting characters. </param>
        /// <returns>A new string that is equivalent to this string except for the removed characters.</returns>
        public static string TryRemove(this string input, int index)
        {
            return input.Length > index ? input.Remove(index) : input;
        }

        /// <summary>
        /// Gets the headers for this Url, and returns whether its mime-type is an image or not.
        /// </summary>
        /// <param name="url">The url to check.</param>
        /// <returns>True if the server-returned mime-type starts with "image/", false otherwise.</returns>
        public static bool IsImageUrl(this string url)
        {
            var req = (HttpWebRequest) WebRequest.Create(url);
            req.Method = "HEAD";
            using (var resp = req.GetResponse())
            {
                return resp.ContentType.ToLower(CultureInfo.InvariantCulture)
                    .StartsWith("image/");
            }
        }

        public static bool EndsWith(this string i, params string[] matches) => matches.All(i.EndsWith);

        public static bool StartsWith(this string i, params string[] matches) => matches.All(i.StartsWith);

        public static bool EndsWithAny(this string i, params string[] matches) => matches.Any(i.EndsWith);

        public static bool StartsWithAny(this string i, params string[] matches) => matches.Any(i.StartsWith);

        public static bool EqualsAny(this string i, params string[] matches) => matches.Any(m => i == m);

        public static bool EqualsAll(this string i, params string[] matches) => matches.All(m => i == m);
    }
}