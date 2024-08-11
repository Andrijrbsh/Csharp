using System;

namespace Task12
{
    class Program 
{
        static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a number: ");
        string inputFromUser = Console.ReadLine();
        if (int.TryParse(inputFromUser, out int outputFromUser))
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    System.Console.Write(outputFromUser + " ");
                }
                System.Console.WriteLine();

                for (int j = 0; j < 4; j++)
                {
                    System.Console.Write(outputFromUser);
                }
                System.Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
}
