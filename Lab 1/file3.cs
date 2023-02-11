using System;

public  class file3{
	public static void Main(string[] args){
		Console.WriteLine("Basic Calculator : " + args[0] + args[1] + args[2]);	
		int n1 = int.Parse(args[1]);
		int n2 = int.Parse(args[2]);
		if(args[0] == "+")
		{
			Console.WriteLine("Addition is : " + (n1 + n2));
		}
		else if(args[0] == "-")
		{
			Console.WriteLine("Subtraction is : " +(n1 - n2));
		}
		else if(args[0] == "*")
		{
			Console.WriteLine("Multiplication is : " +(n1 * n2);
		}
		else if(args[0] == "/")
		{
			Console.WriteLine("Division is : "+(n1/n2));
		}	
		
		else
		{
			Console.WriteLine("Invalid Input!");
		}
	}
}