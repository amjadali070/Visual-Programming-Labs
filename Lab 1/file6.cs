using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
			
			Console.Write("Enter First Value: ");
			string n1 = Console.ReadLine();
			Console.Write("Enter Second Value: ");
			string n2 = Console.ReadLine();
			Console.Write("Enter Operator: ");
			string oper = Console.ReadLine();

			int num1 = int.Parse(n1);
			int num2 = int.Parse(n2);
			if (oper == "+")
			{
				Console.WriteLine("Addition: " + (num1 + num2));
			}
			else if (args[0] == "-")
			{
				Console.WriteLine("Subtraction: " + (num1 - num2));
			}
			else if (args[0] == "*")
			{
				Console.WriteLine("Multiplication: " + (num1 * num2));
			}
			else if (args[0] == "/")
			{
				Console.WriteLine("Division: " + (num1 / num2));
			}
		}
    }
}
