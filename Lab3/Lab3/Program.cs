using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of a shape (Circle, Rectangle):");
            string shapeName = Console.ReadLine();
            if(shapeName == "Circle")
            {
                areaCicle();
            }
            else if (shapeName == "Rectangle")
            {
                Console.WriteLine("This is Rectangle");
            }
        }

        public static void areaCicle()
        {
            Console.WriteLine("This is Circle");
            Console.WriteLine("This is Circle");
            Console.WriteLine("This is Circle");


        }
    }
}
