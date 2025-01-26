using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class EmptyStackException : Exception
    {
        public EmptyStackException(string message):base(message)
        {
            
        }
    }
}
