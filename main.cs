using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main() 
        {
        	int n1 = 0;
        	string input;
        	string op;
        	int n2;
        	int ans = 0;
        	
        	Console.Write("Input first number: ");
        	input = Console.ReadLine();
        	Int32.TryParse(input, out n1);
        	
        	Console.Write("Input operator: ");
        	op = Console.ReadLine();
        	
        	Console.Write("Input second number: ");
        	input = Console.ReadLine();
        	Int32.TryParse(input, out n2);
        	
        	if(op == "+")
        	{
        		ans = n1 + n2;
        	}
        	if(op == "-")
        	{
        		ans = n1 - n2;
        	}
        	if(op == "*")
        	{
        		ans = n1 * n2;
        	}
        	if(op == "/")
        	{
        		ans = n1 / n2;
        	}
        	
        	Console.WriteLine(n1.ToString() + op + n2.ToString() + "=" + ans.ToString());
        }
    }
}