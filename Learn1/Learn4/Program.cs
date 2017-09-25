using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn4
{
    class Program
    {

        //Функции, return

        //Функция, не возвращает значение:

        /*
        public static void ReplaceName(string[] names, string name, string newName)
        {
            int c = 0;
            foreach (string el in names)
            {
                if (el == name)
                {
                    names[c] = newName;
                    c++;
                }
                else
                {
                    c++;
                }
            }
        }

        static void Main(string[] args)
        {
            string[] names = { "Alex", "Max", "Vitya", "Max", "Serg" };
            ReplaceName(names, "Max", "NewMax");
            foreach (string el in names)
            {
                Console.WriteLine(el);
            }
            Console.ReadKey();
          */

        //Функция, возвращающая значение

        /*

        public static int GetMax(int[] array)
        {
            int max = array[0];
            foreach (int i in array)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }

        static void Main(string[] args)
        {
            int[] numbers = { 2, 56, 234, 7567, 2345, 567567, 22, 33, 545, 1, 2, 3, 4, 3453454, 345345, 132, 43433, 23, 3 };
            int max = GetMax(numbers);
            Console.WriteLine(max);
            Console.ReadKey();

        }
        */

        //Homework

        //Задача 1. Напишите функцию, которая будет менять в массиве целых чисел все элементы,
        //которые равны указанному значению (аргумент) на противоположное значение по знаку.
        //Например, все элементы массива которые равны 5, будут меняться на -5.

        /*
        public static void ReplaceSign(int[] array, int number, int replacednumber)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    array[i] = replacednumber;
                }
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = { 4, 5, 6, 78, 1, 2, 3, 4, 5, 6, 777, 3 };
            ReplaceSign(numbers, 3, -3);
            foreach (int el in numbers)
            {
                Console.WriteLine(el);
            }
            Console.ReadKey();
        }
        */

        //Задача 2. Напишите функцию, которая будет находить минимальное число из трех.

        /*

        public static int FindMin(int a, int b, int c)
        {
            int min = a;
            if (b < a && b < c)
            {
                min = b;
            }
            if (c < a && c < b)
            {
                min = c;
            }
            return min;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num1 = rnd.Next(1, 100);
            int num2 = rnd.Next(1, 100);
            int num3 = rnd.Next(1, 100);
            int min = FindMin(num1, num2, num3);
            Console.WriteLine("1 - {0}, 2 - {1}, 3 - {2}, min - {3}", num1, num2, num3, min);
            Console.ReadKey();
        }
        */

        // Задача 3. Напишите функцию, которая будет возвращать указанный элемент ряда Фибоначчи.
        //Ряд Фибоначчи – это ряд, в котором каждый следующий элемент равен сумме двух предыдущих.
        //1 1 2 3 5 8 13 21… Функция принимает порядковый номер элемента, и возвращает соответствующий элемент.

        /*

        public static int Fib(int pos)
        {
            if (pos == 1 || pos == 2)
            {
                return 1;
            }
            else
            {
                return Fib(pos - 1) + Fib(pos - 2);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер числа Фиб:");
            int pos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Это число {0}", Fib(pos));
            Console.ReadKey();

        }
        */
    }
}
