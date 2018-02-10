using System;
using System.Windows;
using System.Windows.Interop;

namespace HSNXT
{
    public static partial class Extensions
    {
        public static bool? ShowDialog(this Window win, IntPtr handle)
        {
            var helper = new WindowInteropHelper(win) {Owner = handle};
            return win.ShowDialog();
        }
    }
}