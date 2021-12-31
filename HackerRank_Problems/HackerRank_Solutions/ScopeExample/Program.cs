using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopeExample
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
            Console.ReadKey();
        }

        class Difference
        {
            private int[] elements;
            public int maximumDifference;

            public Difference(int[] _elements)
            {
                this.elements = _elements;
            }
            public void computeDifference()
            {
                Array.Sort(elements);
                maximumDifference = elements[elements.Length - 1] - elements[0];
            }

        }
    }
}
