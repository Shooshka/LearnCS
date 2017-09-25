using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Цикл foreach

            /*
            int[] numbers = { 1, 564, 234, 567, 234, 76 };
            int s = 0;

            foreach (int el in numbers)
            {
                s += el;
            }
            Console.WriteLine(s);
            Console.ReadKey();
            */

            //Homework

            //Используя цикл foreach, выведите на экран все элементы массива целых чисел, которые больше 20 и меньше 50.
            int[] numbers = { 1, 33, 564, 234, 48, 567, 234, 76 };
            foreach (int el in numbers)
            {
                if (el > 20 && el < 50)
                {
                    Console.WriteLine(el);
                }
            }
            Console.ReadKey();

        }
    }
}
