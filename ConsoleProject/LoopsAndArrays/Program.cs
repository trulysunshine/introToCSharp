using System;

namespace AIE
{
    class Program
    {
        static void Main()
        {
            // Arrays
            char singleChar = 'a';

            char[] characters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
            char[] blankChars = new char[3];

            Console.WriteLine(characters[0]);
            characters[1] = '!';
            Console.WriteLine(characters[1]);

            // Loops
            for(int i = 0; i < characters.Length; i++)
            {
                Console.WriteLine(characters[i]);
            }

            foreach(char curChar in characters)
            {
                Console.WriteLine(curChar);
            }

            for(int i = characters.Length - 1; i >= 0; --i)
            {
                Console.WriteLine(characters[i]);
            }

        }
    }
}
