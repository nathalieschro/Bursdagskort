using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace HemmeligProsjekt
{
    internal class Utils
    {
        // START: For manipulating size of console window. Put this in the top of a class in your project, or in top of Program class.
        // USAGE IN MAIN:    
        //                  ShowWindow(MAXIMIZE);

        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        private static IntPtr ThisCon = GetConsoleWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        // State of the application once loaded
        public const int HIDE = 0;
        public const int MAXIMIZE = 3;
        public const int MINIMIZE = 6;
        public const int RESTORE = 9;

        public static void ShowWindow(int nCmdShow)
        {
            ShowWindow(ThisCon, nCmdShow);
        }
        // END

    }
}
