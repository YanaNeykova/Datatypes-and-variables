﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();
            object concatenatedStrings = firstWord + " " + secondWord;
            string greeting = concatenatedStrings.ToString();
            Console.WriteLine(greeting);
        }
    }
}
