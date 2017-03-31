using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[10] {6,3,5,9,1,0,4,2,7,8};

            for (int d = 0; d < number.Length; d++)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (number[i] > number[i + 1])
                    {
                        int guardar = number[i];
                        number[i] = number[i + 1];
                        number[i + 1] = guardar;
                    }
                }
            }

            foreach (int n in number)
            {
                Console.WriteLine(number[n]);
            }
            Console.ReadKey();
        }
    }
}
