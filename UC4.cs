using System;




namespace LineComputation
{
    abstract class Compariso // Creating abstract class
    {
        public abstract void LineComparison(double a, double b); //Abstract Method
    }
    class Lin : Comparison // Inherite Comparison class 
    {
        public double x1, y1, x2, y2, lineLength;
        public void Input() // Class method
        {
            Console.WriteLine("\nEnter first point X coordinate x1: ");
            x1 = Convert.ToDouble(Console.ReadLine()); // reads x - coordinate of starting point for line 1
            Console.WriteLine("Enter first point Y coordinate y1: ");
            y1 = Convert.ToDouble(Console.ReadLine()); // reads y - coordinate of starting point for line 1
            Console.WriteLine("\nEnter second point X coordinate x2: ");
            x2 = Convert.ToDouble(Console.ReadLine()); // reads x - coordinate of end point for line 1
            Console.WriteLine("Enter second point Y coordinate y2: ");
            y2 = Convert.ToDouble(Console.ReadLine()); // reads y - coordinate of end point for line 1
        }
        public double LineLengthComputation(double x1, double y1, double x2, double y2) // Class Method
        {
            double powerx = Math.Pow((x2 - x1), 2);
            double powery = Math.Pow((y2 - y1), 2);
            lineLength = Math.Sqrt((powerx + powery)); // Finding  Length of line
            return lineLength; // return length of line
        }
        public override void LineComparison(double lineLength1, double lineLength2) // Overriding abstract Method of inherited class
        {
            Console.WriteLine("\n\nComparison between lines....");
            int result;
            Console.Write("\n\nFirst Line is Equal To Second Line : ");
            Console.WriteLine(lineLength1.Equals(lineLength2));
            result = lineLength1.CompareTo(lineLength2); // Comparing two lines
            if (result > 0)
                Console.WriteLine($"\n So First line is greater than Second line");

            else if (result < 0)
                Console.WriteLine($"\n So First line is less than Second line");
            else
                Console.WriteLine($"\nSo First Line and Second Line Both are Equal");
        }
    }
    internal class Programs
    {
        public void progs()
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            Console.WriteLine("\nFor First Line......");
            Line line1 = new Line(); // Creating object for line 1
            line1.Input(); // Call the function input to provide line 1 points
            double lineLength1 = line1.LineLengthComputation(line1.x1, line1.y1, line1.x2, line1.y2); // Storing line 1 length
            Console.WriteLine($"\nLength of line using two points ({line1.x1},{line1.y1}) and ({line1.x2},{line1.y2}) is : {lineLength1}");
            Console.WriteLine("\n\nFor Second Line......");
            Line line2 = new Line(); // Creating object for line 1
            line2.Input();// Call the function input to provide line 1 points
            double lineLength2 = line2.LineLengthComputation(line2.x1, line2.y1, line2.x2, line2.y2); // Storing line 2 length
            Console.WriteLine($"\nLength of line using two points ({line2.x1},{line2.y1}) and ({line2.x2},{line2.y2}) is : {lineLength2}");
            line1.LineComparison(lineLength1, lineLength2); // Calling Compare method 
            Console.ReadLine();

        }
    }
}