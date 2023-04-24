using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Symbol");
            string symbol = Console.ReadLine();
            Palindrome(symbol);
        }

        // Palindrome Method
        static void Palindrome(string myString)
        {
            int length = myString.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (myString[i] != myString[length - i - 1])
                {
                    Console.WriteLine("Not a Palindrome");
                    return;
                }
            }
            Console.WriteLine("Palindrome!!");
        }
    }
}
