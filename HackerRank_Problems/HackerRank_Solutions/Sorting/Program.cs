using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            // Write your code here
            int NoOfSwaps = 0;

            for (int i = 0; i < a.Count; i++)
            {
                int Swaps = 0;
                for (int j = i + 1; j < a.Count; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[j];
                        a[j] = a[i];
                        a[i] = temp;
                        Swaps++;
                        NoOfSwaps++;
                    }
                }
                if (Swaps == 0) { break; }

            }

            Console.WriteLine("Array is sorted in " + NoOfSwaps + " swaps.");
            Console.WriteLine("First Element: " + a[0]);
            Console.WriteLine("Last Element: " + a[a.Count - 1]);
        }
    }
}
