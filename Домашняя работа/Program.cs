﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static int Menu()
        {
            int m;
            do
            {
                Console.WriteLine("\t1 - Task1");
                Console.WriteLine("\t2 - Task2");
                Console.WriteLine("\t3 - Task3");
                Console.WriteLine("\t4 - Task4");
                Console.WriteLine("\t0 - Exit");
                //m = Convert.ToInt32(Console.ReadLine());
                string s = Console.ReadLine();
                m = Convert.ToInt32(s);
            }
            while (m<0 && m>3);
            return m;
        }
        static void Main(string[] args)
            {
                int menu;
                do
                {
                    menu = Menu();
              
                    switch (menu)
                    {
                        case 1: Homework2.Task1();
                            break;
                        case 2: Homework2.Task2();
                            break;
                        case 3: Homework2.Task3();
                            break;
                        case 4: Homework2.Task4();
                            break;
                        default:
                            Console.WriteLine("Всё");
                            break;
                    }
                }
                while (menu != 0);

        }
    }
}
