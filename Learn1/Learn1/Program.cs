using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1
{
    class Program
    {
        static void Main(string[] args)
        {
            //В Си-шарп объявление массива имеет такую структуру:

            //тип[] имя_массива = new тип[размер массива];

            //int[] numbers = new int[5]; // Создаем массив целых чисел
            //string[] seasons = new string[4] { "зима", "весна", "лето", "осень" }; // Создаем массив строк, инициализируем его значениями.
            // Также корректно пропускать new etc:
            //string[] seasons = { "зима", "весна", "лето", "осень" };
            //numbers[0] = 5;
            //Console.WriteLine(numbers[0] + " " + seasons[0]);
            //Console.ReadKey();

            //Многомерные

            /*
            int[,] numbers1 = new int[2, 2]; //Объявление двумерного массива
            int[,,] numbers2 = new int[2, 2, 3]; //Объявление трехмерного массива
            int[,] numbers3 = new int[3, 2] { { 6, 0 }, { 5, 7 }, { 8, 9 } }; //Объявление и иинициализация двумерного массива

            Console.WriteLine(Convert.ToInt16(numbers1.Length));
            Console.ReadKey();
            */
            
        }
    }
}
