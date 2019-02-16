using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_m2
{
    class Program
    {
        static void Main(string[] args)
        {
            short t;
            while (true)
            {
                Console.Write("Выберите задание от 1 до 10, либо 0 для выхода: "); t = short.Parse(Console.ReadLine());
                if (t == 1) t1();
                else if (t == 2) t2();
                else if (t == 3) t3();
                else if (t == 4) t4();
                else if (t == 5) t5();
                else if (t == 6) t6();
                else if (t == 7) t7();
                else if (t == 8) t8();
                else if (t == 9) t9();
                else if (t == 10) t10();
                else if (t == 0) break;
                else Console.WriteLine("Вы ввели не верное число. Повторите попытку");
            }
        }
        static void t1()
        {
            //1.Написать программу, которая считывает символы с клавиатуры, пока 
            //не будет введена точка.Программа должна сосчитать количество введенных 
            //пользователем пробелов.
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1. Написать программу, которая считывает символы с клавиатуры, \nпока не будет введена точка. Программа должна сосчитать количество \nвведенных пользователем пробелов.\n");
            Console.ForegroundColor = ConsoleColor.White;
            char c;
            int cp = 0;
            while (true)
            {
                c = Console.ReadKey().KeyChar;
                if (c == '.') break;
                else if (c == ' ') cp++;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nКоличество пробелов = {0}", cp);
        }
        static void t2()
        {
            //3.Числовые значения символов нижнего регистра в коде ASCII отличаются от 
            //значений символов верхнего регистра на величину 32.Используя эту информацию, 
            //написать программу, которая считывает с клавиатуры и конвертирует 

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("3.Числовые значения символов нижнего регистра в коде ASCII отличаются от \nзначений символов верхнего регистра на величину 32.Используя эту информацию, \nнаписать программу, которая считывает с клавиатуры и конвертирует ");
            Console.ForegroundColor = ConsoleColor.White;
            string st1 = string.Empty;
            string st2 = string.Empty;
            char tmp;
            Console.WriteLine("наберите текст в нижнем регистре: ");
            st1 = Console.ReadLine();

            for (int i = 0; i < st1.Length; i++)
            {
                tmp = (char)((int)st1[i] - 32);
                st2 += tmp;
            }
            Console.WriteLine(st2);

        }
        static void t3()
        {
            //4.Даны целые положительные числа A и B (A < B).Вывести все целые числа от 
            //A до B включительно; каждое число должно выводиться на новой строке; 
            //при этом каждое число должно выводиться количество раз, равное его значению. 
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("4.Даны целые положительные числа A и B (A < B).Вывести все целые числа от \nA до B включительно; каждое число должно выводиться на новой строке; \nпри этом каждое число должно выводиться количество раз, равное его значению. ");
            Console.ForegroundColor = ConsoleColor.White;

            int A, B;
            Console.Write("Введите два числа А и В, А>B\nA: ");
            A = int.Parse(Console.ReadLine()); Console.Write("\nB: ");
            B = int.Parse(Console.ReadLine());

            for (int i = B; i <= A; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i.ToString() + " ");
                }
                Console.WriteLine("\t");
            }
        }
        static void t4()
        {
            //8.Дано расстояние в сантиметрах.Найти число полных метров в нем.
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("8.Дано расстояние в сантиметрах.Найти число полных метров в нем.");
            Console.ForegroundColor = ConsoleColor.White;

            int sm, m;
            Console.Write("Введите растояние в сантиметрах: ");
            sm = int.Parse(Console.ReadLine());
            m = sm / 100;
            Console.WriteLine("В {0} сантиметрах {1} полных метров", sm, m);
        }
        static void t5()
        {
            //10.Дано двузначное число. Найти: a.число десятков в нем; b.число единиц в нем;
            //c.сумму его цифр; d.произведение его цифр
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("10.Дано двузначное число. Найти: a.число десятков в нем; b.число единиц в нем;\nc.сумму его цифр; d.произведение его цифр");
            Console.ForegroundColor = ConsoleColor.White;

            string inputText = string.Empty;
            int a = 0;
            Console.Write("Введите двухзначное число: ");
            while (a < 2)
            {
                ConsoleKeyInfo keyPress = Console.ReadKey(true);
                char input = keyPress.KeyChar;

                if (char.IsControl(input))
                {
                    break;
                }

                if (char.IsDigit(input))
                {
                    inputText += input;
                    Console.Write(input);
                }
                a++;
            }
            int d, i;
            d = int.Parse(inputText[0].ToString());
            i = int.Parse(inputText[1].ToString());
            Console.WriteLine("\nДесятки: {0}, единицы: {1}, сумма цифр: {2}, произведение: {3}", d, i, d + i, d * i);
        }
        static void t6()
        {
            //42.Напечатать таблицу умножения на 9: 9 х 1 = 9 9 х 2 = 18... 9 х 9 = 81
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("42.Напечатать таблицу умножения на 9: 9 х 1 = 9 9 х 2 = 18... 9 х 9 = 81");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine("9x{0}={1}\n", i, 9 * i);
            }
        }
        static void t7()
        {
            //36.Составить программу, которая в зависимости от порядкового номера дня 
            //месяца (1, 2, ..., 12) выводит на экран время года, к которому относится 
            //этот месяц.
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("36.Составить программу, которая в зависимости от порядкового номера дня \nмесяца (1, 2, ..., 12) выводит на экран время года, к которому относится \nэтот месяц.");
            Console.ForegroundColor = ConsoleColor.White;

            string m = "";
            Console.Write("Введите порядковый номер месяца(1-12): ");
            m = Console.ReadLine();
            if (m == "1" || m == "2" || m == "12") Console.WriteLine("Зима");
            else if (m == "3" || m == "4" || m == "5") Console.WriteLine("Весна");
            else if (m == "6" || m == "7" || m == "8") Console.WriteLine("Лето");
            else if (m == "9" || m == "10" || m == "11") Console.WriteLine("Осень");
        }
        static void t8()
        {
            //27.Вычислить значение логического выражения при следующих значениях логических 
            //величин X, Y и Z: X = Ложь, Y = Истина, Z = Ложь: a.X или Z; b.X и Y; c.X и Z.

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("27.Вычислить значение логического выражения при следующих значениях логических \nвеличин X, Y и Z: X = Ложь, Y = Истина, Z = Ложь: a.X или Z; b.X и Y; c.X и Z.");
            Console.ForegroundColor = ConsoleColor.White;

            bool X = false, Y=true, Z=false;
            if (X || Y) Console.WriteLine("X или Y = Истина");
            else Console.WriteLine("X или Y = Ложь");
            if (X & Y) Console.WriteLine("X и Y = Истина");
            else Console.WriteLine("X и Y = Ложь");
            if (X & Z) Console.WriteLine("X и Z = Истина");
            else Console.WriteLine("X и Z = Ложь");
        }
        static void t9()
        {
            //18. Дана сторона квадрата. Найти его периметр.

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("18. Дана сторона квадрата. Найти его периметр.");
            Console.ForegroundColor = ConsoleColor.White;

            int st;
            Console.Write("Введите длину стороны квадрата: ");
            st= int.Parse(Console.ReadLine());
            Console.WriteLine("Периметр = {0}", st * 4);
        }
        static void t10()
        {
            //17. вычисления значения функции x= 12a2+7a-16 при любом значении а.

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("17. вычисления значения функции x= 12a2+7a-16 при любом значении а.");
            Console.ForegroundColor = ConsoleColor.White;

            double a;
            Console.Write("Введите а: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("12a2+7a-16 = {0}", 12*Math.Pow(a,2)+7*a-16);
        }
    }
}
