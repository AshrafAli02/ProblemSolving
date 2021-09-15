using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rounded_Dice
{
    class Program
    {
        static void Main(string[] args)
        {

            Alternative4();
        }


        public static void ActualMethod()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            double Value = 0;
            for (int i = 1; i <= number; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int Result = 0;
                for (int j = input.Length - 1; j >= 0; j--)
                {
                    Result = (Result * 10) + input[j];
                }
                Value += Result;
                Console.WriteLine(Result + " " + (Value / i).ToString("f1"));
            }
        }
        // 1.Form Maximum Number in Dices Value
        public  static void Alternative1()
        {
            int number = Convert.ToInt32(Console.ReadLine());
           // double Value = 0;
            for (int i = 1; i <= number; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int Result = 0;
                for (int j = input.Length - 1; j >= 0; j--)
                {
                    Result = (Result * 10) + input[j];
                }
                
                Console.WriteLine(Result + "  Max Number: "+FormMaxNumber(Result));
            }
        }
        public static void Alternative2()
        {
            int number = Convert.ToInt32(Console.ReadLine());
           // double Value = 0;
            for (int i = 1; i <= number; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int Result = 0;
                for (int j = input.Length - 1; j >= 0; j--)
                {
                    Result = (Result * 10) + input[j];
                }

                Console.WriteLine(Result + "  Min Number: " + FormMinNumber(Result));
            }
        }


        public static void Alternative3()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int MaxAverage = 0;
            for (int i = 1; i <= number; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int Value = 0;
                int Result = 0;
                for (int j = input.Length - 1; j >= 0; j--)
                {
                    Result = (Result * 10) + input[j];
                }
                 Value += Result;
                int avg = Value / i;
                if(MaxAverage<avg)
                {
                    MaxAverage = avg;
                }
            }
            Console.WriteLine("Max Average : " + MaxAverage);
        }


        public static void Alternative4()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int MinAverage = 0;
            for (int i = 1; i <= number; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int Value = 0;
                int Result = 0;
                for (int j = input.Length - 1; j >= 0; j--)
                {
                    Result = (Result * 10) + input[j];
                }
                Value += Result;
                int avg = Value / i;
                if (MinAverage > avg)
                {
                    MinAverage = avg;
                }
            }
            Console.WriteLine("Max Average : " + MinAverage);
        }

        public static int FormMaxNumber(int number) //normal Max 9-0 but here I Know the dices Values is Between 1 to 6 so i run the loop between 1 to 6
        {
            int Result = 0;
            for(int i=6;i>=1;i--)
            {
                int temp = number;
                while(temp>0)
                {
                    int value = temp % 10;
                    if(value==i)
                    {
                        Result = (Result * 10) + value;
                    }
                    temp = temp / 10;
                }
            }
            return Result;
        }

        public static int FormMinNumber(int number)
        {
            int Result = 0;
            for (int i = 1; i <= 6; i++)
            {
                int temp = number;
                while (temp > 0)
                {
                    int value = temp % 10;
                    if (value == i)
                    {
                        Result = (Result * 10) + value;
                    }
                    temp = temp / 10;
                }
            }
            return Result;
        }
    }
}
