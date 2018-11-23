using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int[] num = new int[] { 19, 1, 38, 49, 85, 16, 867, 282 };
            for (int i = 0; i < num.Length - 1; i++)
            {
                for (int j = 0; j < num.Length - 1 - i; j++)
                {
                    if (num[j] > num[j + 1])    
                    {
                        a = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = a;
                    }
                }
            }
            foreach (int number in num)
            {
                Console.Write(number + "   ");
            }
            Console.ReadKey();
        }
    }
}
