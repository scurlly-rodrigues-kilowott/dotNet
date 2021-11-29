// See https://aka.ms/new-console-template for more information


using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstValue = 500;
            int secondValue = 600;
            int largerValue = Math.Max(firstValue, secondValue);

            Console.WriteLine("The larger value is " +largerValue);
        }
    }
}