#if NetFX
using System.Windows.Controls;
using System.Windows.Input;

namespace HSNXT
{
    public static partial class Extensions
    {
        #region TextBox

        public static void SetInputScope(this TextBox tb, InputScopeNameValue inputScopeNameValue)
        {
            tb.InputScope = new InputScope
            {
                Names = {new InputScopeName {NameValue = inputScopeNameValue}}
            };
        }

        #endregion
    }
}
#endif