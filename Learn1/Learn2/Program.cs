using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Циклы служат для многократного повторения некоторого фрагмента кода.
            В Си-шарп есть четыре оператора циклов: for, while, do -while, foreach.
            */

            //Цикл for

            //Этот цикл используется тогда, когда наперед известно, сколько повторений нужно сделать.Он имеет следующую структуру:

            /*
            for (int i = 0; i < 6; i++)
                {
                Console.WriteLine(i);
                Console.ReadKey();
                }
            */

            //Пример программы, которая находит и выводит на экран сумму элементов массива:


            /*
            int[] numbers = { 1, 55, 7, 3 };
            int s = 0;
            for (int i = 0; i < numbers.Length; i++)
            { s += numbers[i]; }
            Console.WriteLine(s);
            Console.ReadKey();
            */

            //Цикл while

            /*
            int i = 0;
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.ReadKey();
            */

            //Цикл do while

            /*
            int number;
            do
            {
                Console.WriteLine("Введите число 5");
                number = Convert.ToInt32(Console.ReadLine());
            }
            while (number != 5);
            */

            //Оператор break

            //Из любого цикла можно досрочно выйти, используя оператор break. Использовать данный оператор есть смысл после удовлетворения некоторого условия, иначе цикл завершится на первой итерации.

            /*
            
            int[] numbers = { 1, 3, 22, 155, 223, 23, 13, 53, 3, 66, 44 };
            bool b = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 13 == 0)
                    {
                    b = true;
                    break;
                    }
            }
            Console.WriteLine(b ? "Кратно 13" : "Некратно 13");
            Console.ReadKey();
            
            */

            /*Пример программы, которая находит сумму нечетных элементов массива:

            int[] numbers = { 1, 22, 34, 55, 66, 7, 88, 9, 324, 4356, 213434, 234234, 1235 };
            int s = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    continue;
                s += numbers[i];
            }
            Console.WriteLine(s);
            Console.ReadKey();
            */

            //Home work

            //Вывести на экран 20 элементов последовательности 1, 4, 7, 10, 13

            /*
            for (int i = 1, c = 0; c < 20; i += 3, c++)
                {
                Console.WriteLine(i);
                }
            Console.ReadKey();
            */

            //Напишите программу, которая будет «спрашивать» правильный пароль, до тех пор, пока он не будет введен. Правильный пароль пусть будет «root».

            /*
            string pass;
            do
            {
                Console.WriteLine("Введите пароль:");
                pass = Console.ReadLine();
            }
            while (pass != "root");
            */

            //Дано два массива одинаковой длины (по 10 элементов).
            //Создайте третий массив, который будет отображать сумму первых двух массивов.
            //Первый элемент третьего массива равен сумме первых элементов двух первых массивов и так далее.

            /*
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arr2 = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int[] arr3 = new int[10];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i] + arr2[i];
                Console.WriteLine(arr3[i]);
            }
            Console.ReadKey();
            */

        }
    }
}
