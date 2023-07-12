using System;
namespace LineComparisonProblem
{
    class program
    {

        static void Main(string[] args)
        {
            //UC1
            Console.WriteLine("Welcome to Line Comparsion Problem statement");
            Operation operation = new Operation(1,2,3,4);
            operation.CalculateLength();
           
        }
    }
}