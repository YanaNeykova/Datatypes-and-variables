using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());
            bool isVowel = "aeoiu".IndexOf(input) >= 0;
            bool isDigit = "0123456789".IndexOf(input) >= 0;

            if (isVowel)
            {
                Console.WriteLine("vowel!");
            }
            else (isDigit)
            {
                Console.WriteLine("digit!");
            }
        }
    }
}
