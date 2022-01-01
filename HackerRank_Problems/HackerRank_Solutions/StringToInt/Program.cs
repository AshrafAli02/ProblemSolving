using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            try
            {
                int Number = Convert.ToInt32(S);
                Console.WriteLine(Number);
            }
            catch
            {
                Console.WriteLine("Bad String");
            }
        }


    }
}
