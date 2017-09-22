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

            int[] numbers = { 1, 55, 7, 3 };
            int s = 0;
            for (int i = 0; i < numbers.Length; i++)
            { s += numbers[i]; }
            Console.WriteLine(s);
            Console.ReadKey();

        }
    }
}
