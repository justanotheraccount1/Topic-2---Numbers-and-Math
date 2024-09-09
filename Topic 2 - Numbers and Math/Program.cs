using System.Diagnostics;

namespace Topic_2___Numbers_and_Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sam Ahrens 09/09/24
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("I will now count my chickens:");
            Console.WriteLine("Hens " + (10 + 5 * 2));
            Console.WriteLine("Roosters " + (25 + 30 / 6));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("I will now count the eggs:");
            Console.WriteLine(11.0 / 2);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Is it true that 3 + 2 < 5 - 7?");
            Console.WriteLine(3 + 2 < 5 - 7);
            Console.WriteLine("What is 3 + 2?" + (3 + 2));
            Console.WriteLine("What is 5 - 7?" + (5 - 7));
            Console.WriteLine("Oh that's why it's " + (3 + 2 < 5 - 7));
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("If you worked for 8 hours making $21.72/hour, you would earn $" + 21.72 * 8);
            Console.WriteLine(" in total");
            Console.WriteLine("If a dozen eggs costs $6, the cost of one egg is $" + (6.00/12));
            Console.Write("If your item costs $79.99, it comes to $" + (79.99 * 1.13));
            Console.WriteLine(" with taxes added");
            Console.Write("If you are 5'6'' tall, you would be " +(((5 * 12) + 6) * 2.54));
            Console.WriteLine("cm tall.");
            
        }  
    }
}
