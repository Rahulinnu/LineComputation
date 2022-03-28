using System;
namespace LineComputation
{
    public class UC1
    {
        public void UsCa1()
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");

            double x1, y1, x2, y2, lineLength;

            Console.WriteLine("Enter first point X coordinate x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter first point Y coordinate y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second point X coordinate x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second point Y coordinate y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            double powerx = Math.Pow((x2 - x1), 2);
            double powery = Math.Pow((y2 - y1), 2);

            lineLength = Math.Sqrt((powerx + powery));

            Console.WriteLine($"Length of line using two points ({x1},{y1}) and ({x2},{y2}) is : {lineLength}");

            Console.ReadLine();
        }
    }
}
