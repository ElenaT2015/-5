using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество  строк и столбцов массива");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[N, N];
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = random.Next(0, 2);
                    Console.Write(" {0,2} " , array[i ,j ]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
