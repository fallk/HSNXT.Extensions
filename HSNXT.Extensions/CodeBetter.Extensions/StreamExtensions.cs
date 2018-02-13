namespace HSNXT
{
    using System.Collections.Generic;
    using System.IO;

    public static partial class Extensions
    {
        /// <summary>
        /// Reads a stream line by line
        /// </summary>            
        /// <returns>The read lines</returns>
        public static List<string> ReadLines(this Stream stream)
        {
            var lines = new List<string>();
            using (var sr = new StreamReader(stream))
            {
                while (sr.Peek() >= 0)
                {
                    lines.Add(sr.ReadLine());
                }
            }

            return lines;
        }

        /// <summary>
        /// Reads a complete stream
        /// </summary>            
        /// <returns>The contents of the stream</returns>
        public static string ReadAll(this Stream stream)
        {
            using (var sr = new StreamReader(stream))
            {
                return sr.ReadToEnd();
            }
        }
    }
}