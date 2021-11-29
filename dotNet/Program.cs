﻿// See https://aka.ms/new-console-template for more information


using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectName = "ACME";

            Console.WriteLine("View English output:\n\t\t" + $@"c:\Exercise\{projectName}\data.txt");

            string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
            string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
            Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");
        }
    }
}