using System.Xml;
using System.Xml.Schema;

namespace HSNXT
{
    public static partial class Extensions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
        static Extensions()
        {
            ReaderSettings.CheckCharacters = true;
            ReaderSettings.ConformanceLevel = ConformanceLevel.Document;
            ReaderSettings.DtdProcessing = DtdProcessing.Prohibit;
            ReaderSettings.IgnoreComments = true;
            ReaderSettings.IgnoreProcessingInstructions = true;
            ReaderSettings.IgnoreWhitespace = true;
            ReaderSettings.ValidationFlags = XmlSchemaValidationFlags.None;
            ReaderSettings.ValidationType = ValidationType.None;
            ReaderSettings.CloseInput = true;

            LookupTableLower = new char[256][];
            LookupTableUpper = new char[256][];
            for (var i = 0; i < 256; i++)
            {
                LookupTableLower[i] = i.ToString("x2").ToCharArray();
                LookupTableUpper[i] = i.ToString("X2").ToCharArray();
            }
            
            LoadOpCodes();
        }

    }
}