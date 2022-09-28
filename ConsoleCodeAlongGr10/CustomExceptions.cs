using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCodeAlongGr10
{
    internal class CustomExceptions : Exception
    {
        [Serializable]
        public class NotEvenNumberException : Exception
        {
            public NotEvenNumberException()
                : base("Not an even number!")
            {

            }
        }
    }
}
