using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Autoteknik
{
    public class BadRegNrException : ArgumentException
    {
        public BadRegNrException() 
        {
            throw new ArgumentException("regNr is not 7 charectors");
        }
    }
}
