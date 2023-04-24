using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
    internal class Program
    {
        // Main Method
        static void Main(string[] args)
        {
            int[] FirstArray = new int[] { 2, 3, 1, 0, 0 };
            int[] SecondArray = new int[] { 2, 2, 3, 0, 0 };
            ShowArray(FiltArray(FirstArray, SecondArray));
        }

        // Show Array Method
        static void ShowArray(int[] Array)
        {
            foreach (var item in Array)
            {
                Console.Write($"{item}" + " ");
            }
            Console.WriteLine("");
        }

        // Filter Array Method
        public static int[] FiltArray(int[] FirstArray, int[] SecondArray)
        {
            List<int> FiltArray = new List<int>(FirstArray);

            foreach (int item in SecondArray)
            {
                FiltArray.RemoveAll(i => i == item);
            }

            return FiltArray.ToArray();
        }
    }
}
