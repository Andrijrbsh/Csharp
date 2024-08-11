using System;

namespace MyConsoleApp
{
    class Program 
{
        static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
         string? number = Console.ReadLine();
         if(int.TryParse(number, out int output))
         {
             for (int i = 0; i <= 10; i++)
             {
                System.Console.WriteLine("{0} * {1} = {2}", output, i, (output * i));
             }
         }
    }
}
}
