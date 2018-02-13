#if NetFX
namespace HSNXT
{
    public static partial class Extensions
    {
        public static ICache GetInstance => new InMemoryCache();
    }
}
#endif