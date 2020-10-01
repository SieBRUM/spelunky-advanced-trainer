using System;
using System.Diagnostics;

namespace SpelunkySuperTrainer
{
    public class ProcessInformation
    {
        public Process process;
        public IntPtr hProc, moduleBaseAddress;
    }
}
