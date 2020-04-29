using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    partial class Homework2
    {
        public static void Task2()
        {
            /*
            Тарануха Яна

            Написать метод подсчета количества цифр числа
            */

            Console.WriteLine("Ведите целое число:   ");
            //string str = Console.ReadLine();
            // a = Convert.ToInt32(str);
            int a = Convert.ToInt32(Console.ReadLine());

            int i = 0;

            while (a != 0)
            {

                a = a / 10;
                i++;

            }
            Console.WriteLine("Число состоит из {0} цифр.", i);
            Console.ReadKey();

            //Console.WriteLine("Result:");
        }
    }
}
