using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleCodeAlongGr10.CustomExceptions;

namespace ConsoleCodeAlongGr10
{
    public class NumberHandling
    {
        List<int> listOfNumbers = new List<int>();
        static StringBuilder sb = new StringBuilder(); 
        public void AddNumber()
        {
            Console.Write("Please enter a number: ");
            try
            {
                int numberToAdd = Convert.ToInt32(Console.ReadLine());

                if (numberToAdd % 2 == 0)
                    listOfNumbers.Add(numberToAdd);
                else
                    throw new NotEvenNumberException();
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                sb.AppendLine($"Error: {ex.Message} {DateTime.Now}");
                Console.ReadKey();
                Console.Clear();
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                sb.AppendLine($"Error: {ex.Message} {DateTime.Now}");
                Console.ReadKey();
                Console.Clear();
            }
            catch (NotEvenNumberException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                sb.AppendLine($"Error: {ex.Message} {DateTime.Now}");
                Console.ReadKey();
                Console.Clear();
            }

        }
        public void PrintNumbers()
        {
            Console.Write("Numbers in the list: ");
            foreach (int number in listOfNumbers)
            {
                Console.Write(number + " ");
            }
            Console.ReadKey();
        }

        public void CheckErrors()
        {
            Console.WriteLine("The following errors have occured in the program:");
            Console.WriteLine(sb);
            Console.ReadKey();
        }
    }
}
