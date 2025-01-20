using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace HWExceptions
{
    public class WrongLoginException: Exception
    {
        public WrongLoginException(string message) : base(message)
        {
            
        }
    }
}
