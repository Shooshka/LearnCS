using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Обработка исключений в Си-шарп. Оператор try-catch 

            //Для обработки исключений в Си - шарп используется оператор try-catch. Он имеет следующую структуру:

            //try
            //{
            //    //блок кода, в котором возможно исключение
            //}
            //catch ([тип исключения][имя])
            //{
            //    //блок кода – обработка исключения
            //}

            //Ниже приведен пример программы, в которой используется обработка исключения некорректного формата данных:

            //string result = "";
            //Console.WriteLine("Введите число");
            //try
            //{
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    result = "Вы ввели число " + a;
            //}
            //catch (FormatException)
            //{
            //    result = "Вы ввели не число!";
            //}
            //Console.WriteLine(result);
            //Console.ReadKey();

            //Типы исключений

            //Ниже приведены некоторые из часто встречаемых типов исключений.

            //Exception – базовый тип всех исключений. Блок catch, в котором указан тип Exception будет «ловить» все исключения.
            //FormatException – некорректный формат операнда или аргумента(при передаче в метод).
            //NullReferenceException - В экземпляре объекта не задана ссылка на объект, объект не создан
            //IndexOutOfRangeException – индекс вне рамок коллекции
            //FileNotFoundException – файл не найден.
            //DivideByZeroException – деление на ноль

            //Несколько блоков catch

            //Одному блоку try может соответствовать несколько блоков catch:

            //try
            //{
            //    //блок1
            //}
            //catch (FormatException)
            //{
            //    //блок-обработка исключения 1
            //}
            //catch (FileNotFoundException)
            //{
            //    //блок-обработка исключения 2
            //}


            //Блок finally

            //Оператор try-catch также может содержать блок finally.
            //Особенность блока finally в том, что код внутри этого блока выполнится в любом случае, в независимости от того, было ли исключение или нет.

            //try
            //{
            //    //блок1
            //}
            //catch (Exception)
            //{
            //    //обработка исключения
            //}
            //finally
            //{
            //    //блок кода, который выполнится обязательно
            //}

            //Домашнее задание

            //Есть массив целых чисел размером 10.
            //С клавиатуры вводится два числа -порядковые номера элементов массива, которые необходимо суммировать.
            //Например, если ввели 3 и 5 - суммируются 3 - й и 5 - й элементы.
            //Нужно предусмотреть случаи, когда были введены не числа, и когда одно из чисел, или оба больше размера массива.

            int[] array = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 100);
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("Введите номер 1го элемента массива, а затем 2го, которые нужно сложить");
            try
            {
                Console.WriteLine("Сумма 2ух элементов массива равна " + (array[Convert.ToInt32(Console.ReadLine())] + array[Convert.ToInt32(Console.ReadLine())]));
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели не числа!");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("У нас массив из 10 чисел!");
            }
            
            Console.ReadKey();



        }
        }
}
