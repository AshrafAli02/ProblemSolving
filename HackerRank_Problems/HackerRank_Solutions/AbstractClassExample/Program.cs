using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            Console.WriteLine(number);
        }
    }
    

    
    public abstract class Book
    {
        private int id { get; set; }
        public abstract string Name{get;set;}
       
    }
        

}
