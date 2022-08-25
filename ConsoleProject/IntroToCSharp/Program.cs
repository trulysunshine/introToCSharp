// See https://aka.ms/new-console-template for more information

using System;

namespace AIE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Heather Brazille");

            int age = 105;

            Console.WriteLine(age);

            Console.WriteLine("What is your favorite piece of candy?");
            string favCandyInput = Console.ReadLine();
            Console.WriteLine("Your favorite candy is " + favCandyInput);

            if(favCandyInput == "Crunch")
            {
                Console.WriteLine("Crunch? You have AMAZING taste!");
            }
            else if(favCandyInput == "Kit-Kat")
            {
                Console.WriteLine("Kit-Kats are nice.");
            }
            else
            {
                Console.WriteLine("I don't really know what that is, but sounds good.");
            }

            string numberInput = Console.ReadLine();
            int userNumber = 0;
            int.TryParse(numberInput, out userNumber);
            Console.WriteLine("You wrote the number " + userNumber);
            Console.WriteLine("If squared, it would be " + userNumber * userNumber);
        }
    }
}