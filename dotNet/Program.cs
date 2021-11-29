// See https://aka.ms/new-console-template for more information


using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //purpose of this code is to reverse a string and count the number of times a particular character appears.


            string str = "The quick brown fox jumps over the lazy dog.";

            int x = 0;

            char[] charMessage = str.ToCharArray();

            Array.Reverse(charMessage);

            foreach (char i in charMessage)
            {
                if (i == 'o')
                {
                    x++;
                }
            }

            string new_message = new String(charMessage);

            Console.WriteLine(new_message);

            Console.WriteLine($"'o' appears {x} times.");
        }
    }
}