using System;
using System.Runtime.InteropServices;

namespace HMI
{
    public class Attempt
    {
        [DllImport("attemptDll.dll")]
        public static extern IntPtr Create(int x);

        [DllImport("attemptDll.dll")]
        public static extern int AttemptAdd(IntPtr a, int y);

        public int AttemptFunc()
        {
            IntPtr a = Create(5);
            int result = AttemptAdd(a, 10);
            return result;
        }
    }
}
