using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 7 элементов массива");
            const int  n  = 7;
            int[] array = new int[n];
            double S = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                S += array[i];         
            }
            Console.WriteLine(" Среднее арифмитческое значение = {0:f3}", S / n);
            Console.ReadKey();
        }
    }
}
