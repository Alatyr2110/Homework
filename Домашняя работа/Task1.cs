using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    partial class Homework2
    {
        public static void Task1()
        {
            /*
            Тарануха Яна
            Написать метод, возвращающий минимальное из трёх чисел
            */

            double a;
            double b;
            double c;
            
            Console.Write("Ведите первое число:   ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число:   ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите третье число:   ");
            c = Convert.ToDouble(Console.ReadLine());

            if (a <= b & a <= c)
            {
                Console.WriteLine("Наименьшее число:   " + $"{ a}");
            }
            if (b < a & b < c)
            {
                Console.WriteLine("Наименьшее число:   " + $"{ b}");
            }
            if (c < a & c < b)
                Console.WriteLine("Наименьшее число:   " + $"{ c}");

            Console.ReadKey();
            //Console.WriteLine("Result:");
        }
    }
}
