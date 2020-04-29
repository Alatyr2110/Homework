using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    partial class Homework2
    {
        public static void Task4()
        {
            /*
            Тарануха Яна

            Реализовать метод проверки логина и пароля. 
            На вход метода подается логин и пароль. 
            На выходе истина, если прошел авторизацию, и ложь, 
            если не прошел (Логин: root, Password: GeekBrains). 
            Используя метод проверки логина и пароля, 
            написать программу: пользователь вводит логин и пароль, 
            программа пропускает его дальше или не пропускает. 
            С помощью цикла do while ограничить ввод пароля тремя попытками.
            */

            ConsoleColor prevColor = Console.ForegroundColor;
            int i = 0;
            do
            {
                Console.Write("Введите Ваш логин:     ");
                string userLogin = Console.ReadLine();

                Console.Write("Введите Ваш рassword:     ");
                string userPassword = Console.ReadLine();

                var login = "root";
                var password = "GeekBrains";
                var d = "";
                var z = "";

                if (login == userLogin & password == userPassword)
                {
                    i = 3;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\n\t******Все верно******");
                }
                else
                {
                    i++;
                    int c = 3 - i;

                    if (c == 2)
                        d = "ки";
                    if (c == 1)
                        d = "ка";
                    if (c == 0)
                    {
                        d = "ок";
                        z = "\n\tКак говорится: <<Поздно пить <<Borjomi>>";
                    }
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nНеверно, у Вас осталось: " + $"{c}" + " попыт" + $"{d}" + ".");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{z}", z);

                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            while (i < 3);

            Console.ReadKey();
            //Console.WriteLine("Result:");
        }
    }
}
