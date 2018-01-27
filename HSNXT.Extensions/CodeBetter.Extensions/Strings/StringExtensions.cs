namespace CodeBetter.Extensions
{
   using System;
   using System.Globalization;
   using System.Text.RegularExpressions;
   
   public static class StringExtensions
   {
      
      private static readonly Regex _htmlTagPattern = new Regex(@"<\/?[^>]*>", RegexOptions.Compiled | RegexOptions.Multiline);
      private static readonly Regex _multipleSpaces = new Regex(@"\s{2,}", RegexOptions.Compiled | RegexOptions.Multiline);
      private static readonly Regex _noSpaceAfterPunctuation = new Regex(@"([\.\?\!,:;\-]""?)(\S)", RegexOptions.Compiled | RegexOptions.Multiline);
      private static readonly Regex _firstLowerCaseLetterAfterSentence = new Regex(@"(\.\s*)([a-z])", RegexOptions.Compiled | RegexOptions.Multiline);
      private static readonly Regex _lowercaseI = new Regex(@"([\s\p{P}])i([\s\p{P}])", RegexOptions.Compiled | RegexOptions.Multiline);     
      

      /// <summary>
      /// Compares a string to a given string. The comparison is case insensitive.
      /// </summary>      
      /// <param name="compareTo">The string to compare against</param>
      /// <returns>True if the strings are the same, false otherwise.</returns>
      public static bool Is(this string @string, string compareTo)
      {
         return string.Compare(@string, compareTo, true) == 0;
      }

      /// <summary>
      /// Creates a type from the given name
      /// </summary>
      /// <typeparam name="T">The type being created</typeparam>      
      /// <param name="args">Arguments to pass into the constructor</param>
      /// <returns>An instance of the type</returns>
      public static T CreateType<T>(this string typeName, params object[] args)
      {
         Type type = Type.GetType(typeName, true, true);
         return (T)Activator.CreateInstance(type, args);
      }

      /// <summary>
      /// Replaces each newline with a &lt;br /&gt; tag
      /// </summary>      
      public static string NewlineToBr(this string html)
      {
         return html.Replace(Environment.NewLine, "<br />");
      }

      /// <summary>
      /// Removes html tags from a given strnig
      /// </summary>      
      public static string StripHtml(this string html)
      {
         return _htmlTagPattern.Replace(html, "");
      }

      /// <summary>
      /// Removes extra spaces within a string
      /// </summary>      
      public static string Strip(this string @string)
      {
         return _multipleSpaces.Replace(@string, " ");
      }

      /// <summary>
      /// Fixes a paragraph so that it more properly conforms to english rules (single space after punctuation,
      /// capitalization and so on).
      /// </summary>      
      public static string Proper(this string paragraph)
      {
         paragraph = _noSpaceAfterPunctuation.Replace(paragraph, "$1 $2").Strip();
         paragraph = _firstLowerCaseLetterAfterSentence.Replace(paragraph, m => m.Groups[1].Value + m.Groups[2].Value.ToUpper());
         paragraph = paragraph.Substring(0, 1).ToUpper() + paragraph.Substring(1);
         paragraph = _lowercaseI.Replace(paragraph, "$1I$2");
         return paragraph;
      }

      /// <summary>
      /// Reverse the order of a string
      /// </summary>      
      public static string Reverse(this string @string)
      {
         var reversed = @string.ToCharArray();
         Array.Reverse(reversed);
         return new string(reversed);
      }

      /// <summary>
      /// Applies formatting to the specified string
      /// </summary>      
      public static string FormatWith(this string @string, params object[] args)
      {
         return string.Format(@string, args);
      }

      /// <summary>
      /// Capitalizes the first letter of a string
      /// </summary>      
      public static string Capitalize(this string @string)
      {
         if (@string.Length == 0)
         {
            return @string;
         }
         if (@string.Length == 1)
         {
            return @string.ToUpper(CultureInfo.InvariantCulture);
         }
         return @string.Substring(0, 1).ToUpper(CultureInfo.InvariantCulture) + @string.Substring(1);
      }

      /// <summary>
      /// Returns the right portion of the string for the specified length
      /// </summary>
      public static string Right(this string @string, int length)
      {
         if (length <= 0 || @string.Length == 0)
         {
            return string.Empty;
         }
         if (@string.Length <= length)
         {
            return @string;
         }
         return @string.Substring(@string.Length - length, length);
      }

      /// <summary>
      /// Returns the left portion of the string for the specified length
      /// </summary>
      public static string Left(this string @string, int length)
      {
         if (length <= 0 || @string.Length == 0)
         {
            return string.Empty;
         }
         if (@string.Length <= length)
         {
            return @string;
         }
         return @string.Substring(0, length);
      }

   }
}
