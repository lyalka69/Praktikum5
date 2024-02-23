using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Задание 1. Определить, является или нет текущий год високосным? Год ввести с клавиатуры.

            //Console.Write("Введите год: ");
            //int year = int.Parse(Console.ReadLine());
            //if (year % 4 == 0 && year % 400 == 0 || year % 100 != 0)//2020,2024
            //{
            //    Console.WriteLine("Високосный год");
            //}
            //else
            //{
            //    Console.Write("Не високосный год");
            //}
            //Console.ReadKey();

            ////Задание 2. Определить, входит ли цена выбранного ноутбука в диапазон от 20 до 30 тыс. р.

            //Console.Write($"Введите стоимость ноутбука в тыс. р.: ");
            //int a = int.Parse(Console.ReadLine());
            //if (a >= 20 & a <= 30)
            //    Console.Write("Входит");
            //else
            //    Console.Write("Не входит");
            //Console.ReadKey();

            ////Задание 3. Написать программу, которая в зависимости от заданного балла определяет оценку учащегося согласно таблице:

            //Console.Write("Введите ваш балл от 1 до 100: ");
            //int point = int.Parse(Console.ReadLine());
            //if (point >= 0 & point < 60)
            //    Console.WriteLine("Неудовлетворительно");
            //if (point == 60)
            //    Console.WriteLine("спорная между уд. и неуд., подарите шампанское и будет уд.)))");
            //if (point > 60 & point <= 74)
            //    Console.WriteLine("Удовлетворительно");
            //if (point >= 75 & point <= 89)
            //    Console.WriteLine("Хорошо");
            //if (point >= 90 & point <= 100)
            //    Console.WriteLine("Отлично");

            //Console.ReadKey();

            ////Задание 4. Вычислить значение функции при целых аргументах:
            ////f = 2x + корень из x; x >= 0 
            ////f = |x| + x^2; x < 0
            //double f = 0, f2 = 0;
            //Console.Write("Введите значение x: ");
            //double x = double.Parse(Console.ReadLine());
            //f = 2 * x + Math.Sqrt(x);
            //f2 = Math.Abs(x) + Math.Pow(x, 2);
            //if (x >= 0)
            //{
            //    Console.WriteLine($"f = {f}");
            //}
            //else if (x < 0)
            //{
            //    Console.WriteLine($"f2 = {f2}");
            //}
            //Console.ReadKey();

            ////Задание 5. Вычислить значение функции при вещественных аргументах:

            //Console.Write("Введите значение для x: ");
            //double x = double.Parse(Console.ReadLine());
            //double f1, f2, f3;
            //f1 = Math.Sqrt(13 - x);
            //f2 = Math.Abs(4*x - 5); 
            //f3 = 3 * Math.Pow(x, 2) - 5 * x;
            //if (x <= -5)
            //    Console.WriteLine($"f1 = {f1}");
            //else if (-5<x & x<5)
            //    Console.WriteLine($"f2 = {f2}");
            //else if (x >= 5)
            //    Console.WriteLine($"f3 = {f3}");
            //Console.ReadKey();

            //1.1

            //Console.WriteLine("Введите значение x: ");
            //double x = double.Parse(Console.ReadLine());
            //double f1, f2;
            //f1 = 2 + 3 * Math.Sqrt(x);
            //f2 = 1 - 2 * Math.Pow(x, 2);
            //if (x >= 0)
            //    Console.WriteLine($"f1 = {f1}");
            //else if (x < 0)
            //    Console.WriteLine($"f2 = {f2}");
            //Console.ReadKey();

            //1.2

            //Console.WriteLine("Введите значение x: ");
            //double x = double.Parse(Console.ReadLine());
            //double f1, f2;
            //f1 = Math.Sin(x);
            //f2 = Math.Abs(Math.Pow(x,3));
            //if (x >= 0)
            //    Console.WriteLine($"f1 = {f1}");
            //else if (x < 0)
            //    Console.WriteLine($"f2 = {f2}");
            //Console.ReadKey();

            //1.3

            //Console.WriteLine("Введите x: ");
            //double x = double.Parse(Console.ReadLine());
            //double y;
            //y = ((3 * Math.Pow(x, 2) + 4) * (Math.Pow(x, 2) - 4)) / (Math.Pow(x, 2) - 81);
            //Console.WriteLine($"y = {y}");
            //Console.ReadKey();

            //1.4

            //Console.WriteLine("Введите x: ");
            //double x = double.Parse(Console.ReadLine());
            //double f1, f2;
            //f1 = Math.Sqrt(Math.Pow(x, 2) - 1);
            //f2 = Math.Pow(x, 2) + 25;
            //if (x >= 0)
            //    Console.WriteLine($"f1 = {f1}");
            //else if (x < 0);
            //Console.WriteLine($"f2 = {f2}");
            //Console.ReadKey();

            //1.5

            //Console.WriteLine("Введите x: ");
            //double x = double.Parse(Console.ReadLine());
            //double y;
            //y = (4 / (2 * x + 10)) + (1 / (3 * x - 9));
            //Console.WriteLine($"y = {y}");
            //Console.ReadKey();

            //1.6

            //Console.WriteLine("Введите x: ");
            //double x = double.Parse(Console.ReadLine());
            //double f1, f2;
            //f1 = 2 * Math.Pow(x, 2) + 5;
            //f2 = -3 * Math.Pow(x, 2);
            //if (x >= 0)
            //    Console.WriteLine($"f1 = {f1}");
            //else if (x < 0)
            //    Console.WriteLine($"f2 = {f2}");
            //Console.ReadKey();

            //1.7

            //Console.WriteLine("Введите x: ");
            //double x = double.Parse(Console.ReadLine());
            //double f1,f2;
            //f1 = 2*x + Math.Sqrt(x);
            //f2 = Math.Abs(x)+Math.Pow(x,2);
            //if (x >= 0)
            //    Console.WriteLine($"f1 = {f1}");
            //else if (x < 0)
            //    Console.WriteLine($"f2 = {f2}");
            //Console.ReadKey();

            //1.8

            //Console.WriteLine("Введите x: ");
            //double x = double.Parse(Console.ReadLine());
            //double f1, f2;
            //f1 = Math.Sqrt(x) + 2* Math.Sin(x);
            //f2 = 6 - Math.Pow(x, 2);
            //if (x >= 0)
            //    Console.WriteLine($"f1 = {f1}");
            //else if (x < 0)
            //    Console.WriteLine($"f2 = {f2}");
            //Console.ReadKey();
        }
    }
}
