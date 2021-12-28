using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> arr = new List<List<int>>();
            List<int> sub = new List<int> { 1, 2, 1,0,0,0 };
            arr.Add(sub);
            List<int> sub1 = new List<int> { 0, 2, 0,0,0,0 };
            arr.Add(sub1);
            List<int> sub2 = new List<int> { 1, 2, 1,0,0,0 };
            arr.Add(sub2);
            List<List<int>> resarr = Form2DArray(arr, 0, 1);
            int res = Get2DSum(arr);
            Console.WriteLine(res);
            
        }

        public static void TDArraySum()
        {
            List<List<int>> arr = new List<List<int>>();
            for(int i=0;i<6;i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int loop = 16;
            int Max = int.MinValue;
            int row = 0;
            int col = 0;
            while(loop!=0)
            {
                int sum = 0;
                for(int i=0;i<3;i++)
                {
                    for(int j=0;j<3;j++)
                    {

                    }
                }
            }
        }

        public static int Get2DSum(List<List<int>> arr)
        {
            int sum = 0;
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    if ((i == 1 && j == 0) || (i == 1 && j == 2))
                    {
                        continue;
                    }
                    else
                    {
                        sum += arr[i][j];
                    }
                }
            }
            return sum;
        }

        public static List<List<int>> Form2DArray(List<List<int>> arr,int row,int col)
        {
            List<List<int>> resultarr = new List<List<int>>();
            for(int i=row;i<row+3;i++)
            {
                List<int> temp = new List<int>();
                for (int j=col;j<col+3;j++)
                {
                    temp.Add(arr[i][j]);
                }
                resultarr.Add(temp);
            }

            return resultarr;
        }
    }
}
