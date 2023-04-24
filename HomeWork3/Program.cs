using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    internal class Program
    {
        // Main Program
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Symbol");
            char symbol = Char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Length");
            int length = Int32.Parse(Console.ReadLine()); ;
            DrawSquare(length, symbol);
        }

        // Draw Square Method
        static void DrawSquare(int length, char symbol)
        {
            int[,] DrawArray = new int[length, length];

            for (int i = 0; i < DrawArray.GetLength(0); i++)
            {
                Console.Write("\n\t");
                for (int j = 0; j < DrawArray.GetLength(1); j++)
                {
                    DrawArray[i, j] += symbol;
                    Console.Write((char)DrawArray[i, j] + " ");
                }
            }
            Console.WriteLine("\n");
        }
    }
}
