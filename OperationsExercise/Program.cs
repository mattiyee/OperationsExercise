using System;

namespace OperationsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)
            {
                if (remainder == 1)
                {
                    Console.WriteLine("The equation is valid.");
                }
                else
                {
                    Console.WriteLine("The equation is not valid.");
                }
            }
            else
            {
                Console.WriteLine("The values are not sufficient.");
            }
        }
    }
}
