using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom_Using_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            string word = "asdsaa";

            foreach(char c in word)
            {
                obj.pushCharacter(c);
                obj.enqueChaacter(c);
            }

            bool IsPalindrom = true;
            for(int i=0;i<word.Length;i++)
            {
                if(obj.popCharacter()!=obj.dequeueCharacter())
                {
                    IsPalindrom = false;
                    break;
                }
            }

            Console.WriteLine(IsPalindrom);
            Console.ReadKey();
        }

        Stack<char> WordStack = new Stack<char>();
        Queue<char> WordQueue = new Queue<char>();


        public void pushCharacter(char c)
        {
            WordStack.Push(c);
        }
        public void enqueChaacter(char c)
        {
            WordQueue.Enqueue(c);
        }

        public char popCharacter()
        {
            return WordStack.Pop();
        }
        public char dequeueCharacter()
        {
            return WordQueue.Dequeue();
        }
    }
}
