using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpelunkySuperTrainer
{
    public class ProcessInformation
    {
        public Process process;
        public IntPtr hProc, moduleBaseAddress;
    }
}
