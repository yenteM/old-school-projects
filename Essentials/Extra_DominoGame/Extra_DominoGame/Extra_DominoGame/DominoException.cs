using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_DominoGame
{
    public class DominoException : ApplicationException
    {
        public DominoException(string message) 
            : base(message)
        {}
    }
}
