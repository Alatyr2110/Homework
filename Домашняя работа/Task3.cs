using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    partial class Homework2
    {
        public static void Task3()
        {
            /*
            Тарануха Яна
            С клавиатуры вводятся числа, пока не будет введен 0. 
            Подсчитать сумму всех нечетных положительных чисел
            */

            int a = 0;

            while (true)
            {
                Console.Write("\tВведите число:\n   ");
                string s = Console.ReadLine();
                int b = Convert.ToInt32(s);

                if (b != 0)
                {
                    if (b % 2 == 0) continue;
                    if (b < 0) continue;
                    else
                        a = a + b;
                }
                else
                    break;
            }
            Console.WriteLine("\tСумма всех нечетных положительных чисел: {0}", a);
            Console.ReadKey();
            //Console.WriteLine("Result:");
        }
    }
}
