using System;

class BooleanVariable
{
  
    static void Main(string[] args)
    {
        bool convertedBool = Convert.ToBoolean(Console.ReadLine());
        if (convertedBool)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}