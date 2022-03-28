using System;
namespace LineComputation
{
    public class UC2
    {
        public void UsCa2()
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");

            double x1, y1, x2, y2, lineLength1;

            Console.WriteLine("\nFor First Line......");

            Console.WriteLine("\nEnter first point X coordinate x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter first point Y coordinate y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEnter second point X coordinate x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second point Y coordinate y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            double powerx = Math.Pow((x2 - x1), 2);
            double powery = Math.Pow((y2 - y1), 2);

            lineLength1 = Math.Sqrt((powerx + powery));

            Console.WriteLine($"\nLength of line using two points ({x1},{y1}) and ({x2},{y2}) is : {lineLength1}");


            Console.WriteLine("\n\nFor Second Line......");

            double a1, b1, a2, b2, lineLength2;

            Console.WriteLine("\nEnter first point X coordinate x1: ");
            a1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter first point Y coordinate y1: ");
            b1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEnter second point X coordinate x2: ");
            a2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second point Y coordinate y2: ");
            b2 = Convert.ToDouble(Console.ReadLine());

            double powera = Math.Pow((a2 - a1), 2);
            double powerb = Math.Pow((b2 - b1), 2);

            lineLength2 = Math.Sqrt((powera + powerb));

            Console.WriteLine($"\nLength of line using two points ({a1},{b1}) and ({a2},{b2}) is : {lineLength2}");


            Console.WriteLine("\n\nComparison between lines....");

            Console.Write("\n\nFirst Line is Equal To Second Line : ");
            Console.WriteLine(lineLength1.Equals(lineLength2));

            Console.ReadLine();
        }
    }
}
