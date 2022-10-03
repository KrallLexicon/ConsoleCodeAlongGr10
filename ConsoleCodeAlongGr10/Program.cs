using System.Text;
using static ConsoleCodeAlongGr10.CustomExceptions;


bool isAlive = true;
List<int> listOfNumbers = new List<int>();
StringBuilder sb = new StringBuilder(); 

while (isAlive)
{
    Console.Clear();
    Console.WriteLine("1: Add number to list \n" +
        "2: Check numbers in list \n" +
        "3: Check error history \n" +
        "4: Exit the application");

    ConsoleKey input = Console.ReadKey().Key;
    switch (input)
    {
        case ConsoleKey.D1:
        case ConsoleKey.NumPad1:
            Console.Clear();
            AddNumber();
            break;
        case ConsoleKey.D2:
        case ConsoleKey.NumPad2:
            Console.Clear();
            PrintNumbers();
            break;
        case ConsoleKey.D3:
        case ConsoleKey.NumPad3:
            Console.Clear();
            CheckErrors();
            break;
        case ConsoleKey.D4:
        case ConsoleKey.NumPad4:
            Console.Clear();
            Console.WriteLine("Thank you for using my program!");
            isAlive = false;
            break;
        default:
            Console.Clear();
            Console.WriteLine("Please enter a valid selection");
            break;

    }

}

void AddNumber()
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
void PrintNumbers()
{
    Console.Write("Numbers in the list: ");
    foreach (int number in listOfNumbers)
    {
        Console.Write(number + " ");
    }
    Console.ReadKey();
}
void CheckErrors()
{
    Console.WriteLine("The following errors have occured in the program:");
    Console.WriteLine(sb);
    Console.ReadKey(); 
}

