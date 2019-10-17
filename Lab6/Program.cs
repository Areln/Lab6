using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            string runAgain = "y";
            int userInput = 0;
            while (runAgain != "n")
            {
                Console.WriteLine("Learn your squares and cubes!");
                Console.Write("Please Enter a integer: ");
                while (!int.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.Write("Enter an integer: ");
                }
                Console.WriteLine("Number\tSquared\tCubed");
                Console.WriteLine("======\t======\t======");
                for (int i = 1; i < userInput + 1; i++)
                {
                    Console.WriteLine($"{i}\t{i * i}\t{i * i * i}");
                }
                Console.WriteLine("Run again? (y/n)");
                runAgain = Console.ReadLine();
            }
        }
    }
}
