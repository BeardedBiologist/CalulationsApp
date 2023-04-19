using System;
namespace Calulations
{
	public static class DataCalculations
	{
        public static string getType(string message, double x, double y)
        {
            Console.Write(message);
            string calculationType = Console.ReadLine();

            while (calculationType != "*" && calculationType != "/" &&
                calculationType != "+" && calculationType != "-")
            {
                Console.Clear();
                Console.WriteLine("That is an INVALID operation type.... try again \n\n");
                Console.WriteLine($"Your first number was {x} and your second number was {y}");
                Console.WriteLine(message);
                calculationType = Console.ReadLine();
            }
            return calculationType;

        }

        public static double PerformOperation(double x, double y, string OperationType)
        {
                if (OperationType == "*")
                {
                    double output = x * y;
                    //result = true;
                    return output;
                }
                else if (OperationType == "/")
                {
                    double output = x / y;
                    //result = true;
                    return output;
                }
                else if (OperationType == "+")
                {
                    double output = x + y;
                    //result = true;
                    return output;
                }
                else
                {
                    double output = x - y;
                    //result = true;
                    return output;
                }
        }
    }
}

