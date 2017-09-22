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

            //Класс list

            /*
            Класс List служит для работы со списками, о чем и говорит его название. Это такой «навороченный» массив.
            Главное отличие от простого массива в том, что он динамический – вы можете вставлять и удалять элементы в любое время,
            в то время как в простом массиве размер указывается при создании и сделать его больше или меньше нельзя.
            */

            /*
            List<string> teams = new List<string>(); //Создание списка
            teams.Add("Spartak"); //Добавление элемента в список
            teams.Add("Loko");
            teams.Add("CSKA");

            List<string> teams2 = new List<string>() { "Misfits", "FalloutBoys" }; //Инициализация

            teams.Remove("Loko");
            teams.AddRange(teams2);
            teams.ForEach(i => Console.WriteLine("{0}\t", i));
            Console.ReadKey();
            */



        }
    }
}
