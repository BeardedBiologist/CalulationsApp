using System;
namespace Calulations
{
	public static class DataCalculations
	{
        public static string getType(string message)
        {
            Console.Write(message);
            string calculationType = Console.ReadLine();

            while (calculationType != "*" && calculationType != "/" && calculationType != "+" && calculationType != "-")
            {
                Console.Clear();
                Console.WriteLine("that is not a valid operation type.... try again");
                calculationType = Console.ReadLine();
            }
            return calculationType;

        }

        public static double performOperation(double x, double y)
        {
         
            //bool result = false;

            //while (!result)
            //{
            double nullnull = 0;
            string calculationType = Console.ReadLine();

            try
            {

                if (calculationType == "*")
                {
                    double output = x * y;
                    //result = true;
                    return output;
                }
                else if (calculationType == "/")
                {
                    double output = x / y;
                    //result = true;
                    return output;
                }
                else if (calculationType == "+")
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
            catch (Exception ex)
            {
                Console.WriteLine("Not a valid operation type", ex);
                return nullnull;
            }
                //else
                //{
                //    Console.WriteLine("You have entered an incorrect operation type.");
                //    result = false;
                //}
            //} 

        }
    }
}

