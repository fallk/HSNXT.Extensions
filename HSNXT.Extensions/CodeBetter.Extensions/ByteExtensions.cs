using System.Text;

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Converts a single byte to a hex string
        /// </summary>      
        public static string ToHex(this byte @byte)
        {
            return @byte.ToString("x2");
        }
    }
}