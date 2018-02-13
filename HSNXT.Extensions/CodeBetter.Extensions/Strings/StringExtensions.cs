namespace HSNXT
{
    using System;
    using System.Globalization;
    using System.Text.RegularExpressions;

    public static partial class Extensions
    {
        private static readonly Regex MultipleSpaces =
            new Regex(@"\s{2,}", RegexOptions.Compiled | RegexOptions.Multiline);

        private static readonly Regex NoSpaceAfterPunctuation =
            new Regex(@"([\.\?\!,:;\-]""?)(\S)", RegexOptions.Compiled | RegexOptions.Multiline);

        private static readonly Regex FirstLowerCaseLetterAfterSentence =
            new Regex(@"(\.\s*)([a-z])", RegexOptions.Compiled | RegexOptions.Multiline);

        private static readonly Regex LowercaseI =
            new Regex(@"([\s\p{P}])i([\s\p{P}])", RegexOptions.Compiled | RegexOptions.Multiline);


        /// <summary>
        /// Compares a string to a given string. The comparison is case insensitive.
        /// </summary>
        /// <param name="string">this object</param>
        /// <param name="compareTo">The string to compare against</param>
        /// <returns>True if the strings are the same, false otherwise.</returns>
        public static bool Is(this string @string, string compareTo)
        {
            return string.Compare(@string, compareTo, StringComparison.OrdinalIgnoreCase) == 0;
        }

        /// <summary>
        /// Creates a type from the given name
        /// </summary>
        /// <typeparam name="T">The type being created</typeparam>
        /// <param name="typeName">this object</param>
        /// <param name="args">Arguments to pass into the constructor</param>
        /// <returns>An instance of the type</returns>
        public static T CreateType<T>(this string typeName, params object[] args)
        {
            var type = Type.GetType(typeName, true, true);
            return (T) Activator.CreateInstance(type, args);
        }

        /// <summary>
        /// Replaces each newline with a &lt;br /&gt; tag
        /// </summary>      
        public static string NewlineToBr(this string html)
        {
            return html.Replace(Environment.NewLine, "<br />");
        }

        /// <summary>
        /// Removes extra spaces within a string
        /// </summary>      
        public static string Strip(this string @string)
        {
            return MultipleSpaces.Replace(@string, " ");
        }

        /// <summary>
        /// Fixes a paragraph so that it more properly conforms to english rules (single space after punctuation,
        /// capitalization and so on).
        /// </summary>      
        public static string Proper(this string paragraph)
        {
            paragraph = NoSpaceAfterPunctuation.Replace(paragraph, "$1 $2").Strip();
            paragraph = FirstLowerCaseLetterAfterSentence.Replace(paragraph,
                m => m.Groups[1].Value + m.Groups[2].Value.ToUpper());
            paragraph = paragraph.Substring(0, 1).ToUpper() + paragraph.Substring(1);
            paragraph = LowercaseI.Replace(paragraph, "$1I$2");
            return paragraph;
        }
    }
}