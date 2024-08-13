System.Console.WriteLine("Enter a number: ");
        string? inputFromUser = Console.ReadLine();
        if (int.TryParse(inputFromUser, out int outputFromUser))
        {
            PrintRepeated(outputFromUser, 3);
            System.Console.WriteLine();

            PrintWithSpace(outputFromUser);

            PrintRepeated(outputFromUser, 3);
            System.Console.WriteLine();

            System.Console.ReadKey();
        }

        static void PrintRepeated(int number, int count)
        {
            for (int i = 0; i < count; i++)
            {
                System.Console.Write("{0}", number);
            }
        }
        static void PrintWithSpace(int number)
        {
            System.Console.WriteLine("{0} {0}", number);
        }
