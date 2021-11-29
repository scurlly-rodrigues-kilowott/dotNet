// See https://aka.ms/new-console-template for more information


using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ben";
            int messages = 3;
            decimal temperature = 34.4m;

            Console.Write("Hello, ");
            Console.Write(name);
            Console.Write("! You have ");
            Console.Write(messages);
            Console.Write(" new messages in your inbox. The temperature is ");
            Console.Write(temperature);
            Console.Write(" celsius.");
        }
    }
}