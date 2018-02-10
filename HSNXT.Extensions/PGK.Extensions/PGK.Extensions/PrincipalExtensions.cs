#if NetFX
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Gets property value of a Principals underlying DirectoryEntry object.
        /// </summary>
        /// <param name="principal">The principal.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public static object GetProperty(this Principal principal, string name)
        {
            var directoryEntry = (principal.GetUnderlyingObject() as DirectoryEntry);
            if (!directoryEntry.Properties.Contains(name)) return null;
            
            var property = directoryEntry.Properties[name];
            return property?.Value;
        }
    }
}
#endif