using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCodeAlongGr10
{
    internal class OverloadingExamples
    {
        public void PrintValue()
        {
            Console.WriteLine("This is a hardcoded value");
        }
        public void PrintValue(string value)
        {
            Console.WriteLine($"This is a value based on a parameter: {value}");
        }
        public void PrintValue(string value, int number)
        {
            Console.WriteLine($"This is a value based on two parameters: string: {value}, number: {number}");
        }
        public void PrintValue(int number)
        {
            Console.WriteLine($"This is a value based on a numeric parameter: {number}");
        }
    }
}
