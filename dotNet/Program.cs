// See https://aka.ms/new-console-template for more information


using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int fahrenheit = 94;
            decimal celsius = (fahrenheit - 32) * (5m / 9m);
            Console.WriteLine("The temperature is " + celsius + " Celsius.");
        }
    }
}