using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athlets.Exceptions
{
    internal class RunnerTimeOutOfRangeException : Exception
    {
        public RunnerTimeOutOfRangeException(string? message) : base(message) { }
    }
}
