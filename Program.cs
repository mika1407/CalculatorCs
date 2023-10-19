internal class Program
{
    private static void Main(string[] args)
    {
     do
     {
        double num1 = 0;
        double num2 = 0;
        double result = 0;

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("----------------");
        Console.WriteLine("Calculator Program");
        Console.WriteLine("----------------");
        Console.ResetColor();

        Console.Write("Enter number 1: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter number 2: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Enter an option: ");
        Console.WriteLine("\t+ : Add");
        Console.WriteLine("\t- : Subtract");
        Console.WriteLine("\t* : Multiply");
        Console.WriteLine("\t/ : Divide");
        Console.Write("Enter an option: ");
        Console.ResetColor();

            switch (Console.ReadLine())
        {
            case "+":
                result = num1 + num2;
                Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                break;
            case "-":
                result = num1 - num2;
                Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                break;
            case "*":
                result = num1 * num2;
                Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                break;
            case "/":
                result = num1 / num2;
                Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                break;
            default:
                Console.WriteLine("That was not a valid option");
                break;
        }
        Console.Write("Would you like to continue? (Y = yes, N = No): ");
     } while (Console.ReadLine()!.ToUpper() == "Y");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Bye!");
        Console.ResetColor();

        Console.ReadKey();
    }
}