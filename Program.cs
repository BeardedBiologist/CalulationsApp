using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  BREIF  
//  Create a Console application with static class that
//  handles calculations


namespace Calulations
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //  Ask for numbers (x and y)
            //  Ask for calculation type ( + - * / )
            //  Give Result
            //  Ask user to quit or loop
            //

            string closeProgram = "notYet";

            while (closeProgram != "q" && closeProgram != "Q")
            {
                Console.Clear();
                double x = DataCollection.GetADouble("Please enter your first " +
                        "number: ");
                double y = DataCollection.GetADouble("Please enter your second " +
                    "number: ");
                string OperationType = DataCalculations.getType("What operation " +
                    "would you like to perform? ( *  /  +  -  ): ", x, y);

                double answer = DataCalculations.PerformOperation(x, y, OperationType);

                Console.Clear();
                Console.WriteLine($"{x} {OperationType} {x} = {answer} \n\n");
                closeProgram = DataCollection.GetAString("Press enter to continue or Q to quit:\n");
            }
            Console.Clear();
            Console.WriteLine("Thanks for using this calculator app");
        }
    }
}
