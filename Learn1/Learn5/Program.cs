using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Работа со строками в Си-шарп. Класс String 

            //string s = "Hello";
            //char c = s[1];
            //Console.WriteLine(s);
            //Console.WriteLine(c);
            //Console.WriteLine(s.Length);
            //Console.ReadKey();

            //Спецсимволы

            //Символ "\" является служебным, поэтому, чтобы использовать символ обратного слэша необходимо указывать его дважды "\\".

            //Символ табуляции – "\t"
            //Символ перевода строки – "\r\n"
            //Двойные кавычки – "\""

            //Как проверить, пуста ли строка?

            //string s1 = "", s2 = null, s3 = "some text";
            //Console.WriteLine(string.IsNullOrEmpty(s1));
            //Console.WriteLine(string.IsNullOrEmpty(s2));
            //Console.WriteLine(string.IsNullOrEmpty(s3));
            //Console.ReadKey();

            //Метод IsNullOrWhiteSpace() работает как и метод IsNullOrEmpty(), только возвращает True еще и тогда,
            //когда строка представляет собой набор символов пробела и/или табуляции ("\t"):

            //string s1 = "", s2 = null, s3 = "some text", s4 = "\t";
            //Console.WriteLine(string.IsNullOrWhiteSpace(s1));
            //Console.WriteLine(string.IsNullOrWhiteSpace(s2));
            //Console.WriteLine(string.IsNullOrWhiteSpace(s3));
            //Console.WriteLine(string.IsNullOrWhiteSpace(s4));
            //Console.ReadKey();

            //Как проверить, является ли одна строка "больше" другой?

            //Для сравнивания строк используется метод Compare().
            //Суть сравнения строк состоит в том, что проверяется их отношение относительно алфавита.
            //Строка "a" "меньше" строки "b", "bb" "больше" строки "ba".
            //Если обе строки равны -метод возвращает "0", если первая строка меньше второй – "-1", если первая больше второй – "1":


            //String.Compare("a", "b"); // возвращает -1
            //String.Compare("a", "a"); // возвращает 0
            //String.Compare("b", "a"); // возвращает 1
            //String.Compare("ab", "abc"); // возвращает -1
            //String.Compare("Romania", "Russia"); // возвращает -1
            //String.Compare("Rwanda", "Russia"); // возвращает 1
            //String.Compare("Rwanda", "Romania"); // возвращает 1 

            //
            //Чтобы игнорировать регистр букв, в метод нужно передать, как третий аргумент true.
            //

            //String.Compare("ab", "Ab"); // возвращает -1
            //String.Compare("ab", "Ab", true); // возвращает 0

            //
            //Как перевести всю строку в верхний/нижний регистр?
            //

            //Для этого используются методы ToUpper() и ToLower():

            //string s = "Hello, World!";
            //Console.WriteLine(s.ToUpper());
            //Console.WriteLine(s.ToLower());
            //Console.ReadKey();

            //
            //Как проверить, содержит ли строка подстроку ?
            //

            //Для проверки содержания подстроки строкой используется метод Contains(). 
            //Данный метод принимает один аргумент – подстроку.
            //Возвращает True, если строка содержит подстроку, в противном случае – False. Пример:

            //string s = "Hello, world!";
            //if (s.Contains("Hello"))
            //{
            //    Console.WriteLine("Содержит");
            //}
            //Console.ReadKey();

            //
            //Как найти индекс первого символа подстроки, которую содержит строка?
            //

            //Метод IndexOf() возвращает индекс первого символа подстроки, которую содержит строка.
            //Данный метод принимает один аргумент – подстроку.
            //Если строка не содержит подстроки, метод возвращает "-1".Пример:

            //string s = "Hello, world!";
            //Console.WriteLine(s.IndexOf("llo")); //Выдаст индекс 2
            //Console.WriteLine(s.IndexOf("lloблаблабла")); //Выдаст индекс -1, т.к. подстроки нет.
            //Console.ReadKey();

            //
            //Как узнать, начинается/ заканчивается ли строка указанной подстрокой?
            //

            //Для этого используются соответственно методы StartsWith() и EndsWith(), которые возвращают логическое значение. Пример:

            //string s = "Hello, world!";
            //Console.WriteLine(s.StartsWith("Hell")); // Выдаст True
            //Console.WriteLine(s.StartsWith("Well")); // Выдаст False
            //Console.WriteLine(s.EndsWith("orld!")); // Выдаст True
            //Console.WriteLine(s.EndsWith("orld")); // Выдаст False
            //Console.Read();

            //
            //Как вставить подстроку в строку, начиная с указанной позиции?
            //

            //Метод Insert() используется для вставки подстроки в строку, начиная с указанной позиции.
            //Данный метод принимает два аргумента – позиция и подстрока. Пример:

            //string s = "Hello, world!";
            //Console.WriteLine(s.Insert(0, "!"));//Добавляем символ "!" в 0 индекс и выводим на экран, саму строку при этом не меняем
            //Console.WriteLine(s);//Проверка, что строка не изменилась.
            //s = s.Insert(0, "!");//Меняем строку
            //Console.WriteLine(s);//Проверка, что строка изменилась.
            //Console.ReadKey();

            //
            //Как обрезать строку, начиная с указанной позиции?
            //

            //Метод Remove() принимает один аргумент – позиция, начиная с которой обрезается строка:

            //string s = "Hello, world!";
            //Console.WriteLine(s.Remove(5));//Выводим строку до 5 индекса.
            //Console.WriteLine(s);//Выводим строку
            //s = s.Remove(5);//Меняем строку
            //Console.WriteLine(s);//Выводим строку
            //Console.ReadKey();

            //В метод Remove() можно передать и второй аргумент – количество обрезаемых символов. Remove(3, 5) – удалит из строки пять символов начиная с 3-го.

            //
            //Как получить подстроку из строки, начиная с указанной позиции?
            //

            //Для этого используется метод Substring().Он принимает один аргумент – позиция, с которой будет начинаться новая подстрока:

            //string s = "Hello world!";
            //Console.WriteLine(s.Substring(6, 5));
            //Console.ReadKey();

            //В метод Substring(), как в метод Remove() можно передать и второй аргумент – длина подстроки. Substring (3, 5) – возвратит подстроку длиной в 5 символов начиная с 3-й позиции строки.


            //
            //Как заменить в строке все подстроки указанной новой подстрокой?
            //

            //Метод Replace() принимает два аргумента – подстрока, которую нужно заменить и новая подстрока, на которую будет заменена первая:

            //string s = "Hello world";
            //Console.WriteLine(s.Replace("Hello", "Goodbye"));
            //Console.ReadKey();

            //
            //Как преобразовать строку в массив символов?
            //

            //Метод ToCharArray() возвращает массив символов указанной строки:

            //string s = "Hello world!";
            //char[] array = s.ToCharArray();
            //foreach (char c in array)
            //{
            //    Console.WriteLine(c);
            //}
            //Console.ReadKey();

            //
            //Как разбить строку по указанному символу на массив подстрок?
            //

            //Метод Split() принимает один аргумент - символ, по которому будет разбита строка. Возвращает массив строк. Пример:

            //string s = "Arsenal,Milan,Spartak,Dinamo";
            //string[] array = s.Split(',');
            //foreach (string str in array)
            //{
            //    Console.WriteLine(str);
            //}
            //Console.ReadKey();

            //Неизменяемые строки

            //Стоит знать, что объекты класса String представляют собой неизменяемые(Immutable) последовательности символов Unicode.
            //Когда вы используете любой метод по изменению строки(например Replace()), он возвращает новую измененную копию строки, исходные же строки остаются неизменными.
            //Так сделано потому, что операция создания новой строки гораздо менее затратна, чем операции копирования и сравнения, что повышает скорость работы программы.
            //В Си-шарп также есть класс StringBuilder, который позволяет изменять строки.Об особенностях работы с ним мы поговорим в одном из дальнейших уроков.

            //Домашнее задание

            //Задача 1.Есть некий текст. Необходимо заменить в этом тексте все слова "Nikolay" на "Oleg".

            //string s = "Nikolay,sdfsdf,sdfsdf,sdfsdf,sdf,Nikolay,asdfdf,sdfdsf";
            //Console.WriteLine(s.Replace("Nikolay", "Oleg"));
            //Console.ReadKey();

            //Задача 2.Дан текст – «Сегодня мы с вами рассмотрели, как работать со строками в Си-шарп.
            //Были описаны основные операторы и методы, которые используются для работы со строками».
            //Обрежьте этот текст так, чтобы осталась только часть «Были описаны основные операторы и методы».

            //string s = "Сегодня мы с вами рассмотрели, как работать со строками в Си-шарп. Были описаны основные операторы и методы, которые используются для работы со строками";
            //string news = s.Remove(s.IndexOf(", которы"));
            //Console.WriteLine(news.Substring(news.IndexOf("Были")));
            //Console.ReadKey();

            //Задача 3. Дана строка, которая содержит имена пользователей, разделенные запятой – "Login1,LOgin2,login3,loGin4".
            //Необходимо разбить эту строку на массив строк (чтобы отдельно были логины), и перевести их все в нижний регистр.

            //string s = "Login1,LOgin2,login3,loGin4";
            //foreach (string str in s.Split(','))
            //{
            //    Console.WriteLine(str.ToLower());
            //}
            //Console.ReadKey();


        }
    }
}
