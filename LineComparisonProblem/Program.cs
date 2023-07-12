using System;
namespace LineComparisonProblem
{
    class program
    {

        static void Main(string[] args)
        {
            //UC1
            Console.WriteLine("Welcome to Line Comparsion Problem statement");
            Operation operation1 = new Operation(2, 2, 1, 4);
            double line1 = operation1.CalculateLength();

            Operation operation2 = new Operation(2, 1, 2, 4);
            double line2 = operation2.CalculateLength();

            //Equals - uc2
            if (line1.Equals(line2))
                Console.WriteLine("Line1 is equal to Line2");
            else
                Console.WriteLine("Line1 is not equal to line2");



        }
    }
}