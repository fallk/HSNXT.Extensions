using System.ComponentModel;

/// <summary>
/// 	Extension methods for IComponent data type.
/// </summary>
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// 	Returns <c>true</c> if target component is in design mode.
        /// 	Othervise returns <c>false</c>.
        /// </summary>
        /// <param name = "target">Target component. Can not be null.</param>
        /// <remarks>
        /// 	Contributed by tencokacistromy, http://www.codeplex.com/site/users/view/tencokacistromy
        /// </remarks>
        public static bool IsInDesignMode(this IComponent target)
        {
            var site = target.Site;
            return !ReferenceEquals(site, null) && site.DesignMode;
        }

        /// <summary>
        /// 	Returns <c>true</c> if target component is NOT in design mode.
        /// 	Othervise returns <c>false</c>.
        /// </summary>
        /// <param name = "target">Target component.</param>
        /// <remarks>
        /// 	Contributed by tencokacistromy, http://www.codeplex.com/site/users/view/tencokacistromy
        /// </remarks>
        public static bool IsInRuntimeMode(this IComponent target)
        {
            return !IsInDesignMode(target);
        }
    }
}