using System;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Schema;

namespace HSNXT
{
    public static partial class Extensions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1810:InitializeReferenceTypeStaticFieldsInline")]
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

            // Mannex
            var method = typeof(Exception).GetMethod("PrepForRemoting",
                BindingFlags.Instance | BindingFlags.NonPublic,
                /* binder */ null, Type.EmptyTypes, null);

            PrepForRemoting = method != null
                ? (Func<Exception, Exception>) Delegate.CreateDelegate(typeof(Func<Exception, Exception>), method)
                : (e => e);

            _badFileNameChars = Path.GetInvalidFileNameChars();
            _badFileNameCharsPattern = Patternize(_badFileNameChars);
            _badPathChars = Path.GetInvalidPathChars();
            _badPathCharsPattern = Patternize(_badPathChars);
        }
    }
}