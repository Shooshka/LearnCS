using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Learn7
{
    class Program
    {
        static void Main(string[] args)
        {
            string testfile = "C:\\myprogs\\testcsharp\\test.txt";

            //Работа с файлами в Си-шарп. Классы StreamReader и StreamWriter 

            //В Си-шарп есть пространство имен System.IO, в котором реализованы все необходимые нам классы для работы с файлами.
            //Чтобы подключить это пространство имен, необходимо в самом начале программы добавить строку using System.IO.
            //Для использования кодировок еще добавим пространство using System.Text;

            //Как создать файл ?

            //Для создания пустого файла, в классе File есть метод Create().
            //Он принимает один аргумент – путь.Ниже приведен пример создания пустого текстового файла new_file.txt на диске D:

            //File.Create("C:\\myprogs\\testcsharp\\test.txt");

            //Если файл с таким именем уже существует, он будет переписан на новый пустой файл.

            //Метод WriteAllText() создает новый файл(если такого нет), либо открывает существующий и записывает текст, заменяя всё, что было в файле:

            //File.WriteAllText(testfile, "FileTextNew");

            //Метод AppendAllText() работает, как и метод WriteAllText() за исключением того, что новый текст дописывается в конец файла, а не переписывает всё что было в файле: 

            //File.AppendAllText(testfile, "SomeText\n");

            //Как удалить файл?

            //Метод Delete() удаляет файл по указаному пути, даже если его нет:

            //File.Delete(testfile);

            //Кроме того, чтобы читать / записывать данные в файл с Си - шарп можно использовать потоки.
            //Поток – это абстрактное представление данных(в байтах), которое облегчает работу с ними.В качестве источника данных может быть файл, устройство ввода-вывода, принтер.
            //Класс Stream является абстрактным базовым классом для всех потоковых классов в Си-шарп.Для работы с файлами нам понадобится класс FileStream(файловый поток).
            //FileStream - представляет поток, который позволяет выполнять операции чтения / записи в файл.

            //FileStream file = new FileStream(testfile, FileMode.Open, FileAccess.Read); //Открываем только на чтение

            //Режимы открытия FileMode:

            //-Append – открывает файл(если существует) и переводит указатель в конец файла(данные будут дописываться в конец), или создает новый файл. Данный режим возможен только при режиме доступа FileAccess.Write.
            //- Create - создает новый файл(если существует – заменяет)
            //-CreateNew – создает новый файл(если существует – генерируется исключение)
            //- Open - открывает файл(если не существует – генерируется исключение)
            //- OpenOrCreate – открывает файл, либо создает новый, если его не существует
            //- Truncate – открывает файл, но все данные внутри файла затирает(если файла не существует – генерируется исключение)

            //FileStream file1 = new FileStream("C:\\Myprogs\\testcsharp\\file1.txt", FileMode.CreateNew); //Создание нового файла
            //FileStream file2 = new FileStream("C:\\Myprogs\\testcsharp\\file2.txt", FileMode.Open); //Открытие существующего файла
            //FileStream file3 = new FileStream("C:\\Myprogs\\testcsharp\\file3.txt", FileMode.Append); //Открытие файла с дозаписью в конец

            //Режим доступа FileAccess:

            //-Read – открытие файла только на чтение.При попытке записи генерируется исключение
            //- Write - открытие файла только на запись. При попытке чтения генерируется исключение
            //- ReadWrite - открытие файла на чтение и запись.

            //Чтение из файла

            //Для чтения данных из потока нам понадобится класс StreamReader.
            //В нем реализовано множество методов для удобного считывания данных.
            //Ниже приведена программа, которая выводит содержимое файла на экран:

            //FileStream file1 = new FileStream("C:\\myprogs\\testcsharp\\text.txt", FileMode.Open, FileAccess.Read); //создаем поток только на чтение
            //StreamReader reader1 = new StreamReader(file1); //Создаем потоковый читатель и связываем с потоком
            //Console.WriteLine(reader1.ReadToEnd());
            //reader1.Close();
            //Console.ReadLine();

            //Метод ReadToEnd() считывает все данные из файла.
            //ReadLine() – считывает одну строку(указатель потока при этом переходит на новую строку, и при следующем вызове метода будет считана следующая строка).

            //Свойство EndOfStream указывает, находится ли текущая позиция в потоке в конце потока(достигнут ли конец файла).Возвращает true или false.

            //Запись в файл

            //Для записи данных в поток используется класс StreamWriter. Пример записи в файл:

            //FileStream file1 = new FileStream(testfile, FileMode.Append); //создаем файловый поток
            //StreamWriter writer1 = new StreamWriter(file1); //создаем «потоковый писатель» и связываем его с файловым потоком 
            //writer1.Write("Text");//записываем в файл
            //writer1.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется (!!!)

            //Метод WriteLine() записывает в файл построчно(то же самое, что и простая запись с помощью Write(), только в конце добавляется новая строка).

            //Нужно всегда помнить, что после работы с потоком, его нужно закрыть(освободить ресурсы), использовав метод Close().

            //Кодировка, в которой будут считываться/ записываться данные указывается при создании StreamReader / StreamWriter:

            //FileStream file1 = new FileStream(testfile, FileMode.Open);
            //StreamReader reader1 = new StreamReader(file1, Encoding.Unicode);
            //StreamWriter writer1 = new StreamWriter(file1, Encoding.UTF8);

            //Кроме того, при использовании StreamReader и StreamWriter можно не создавать отдельно файловый поток FileStream, а сделать это сразу при создании StreamReader / StreamWriter:

            //StreamWriter writer1 = new StreamWriter(testfile, append: true);
            //writer1.Write("TextAgain");
            //writer1.Close();

            //Как создать папку?

            //С помощью статического метода CreateDirectory() класса Directory:

            //Directory.CreateDirectory("C:\\myprogs\\testcsharp\\testfolder");

            ////Как удалить папку?

            ////Для удаления папок используется метод Delete():

            ////Directory.Delete("C:\\myprogs\\testcsharp\\testfolder");

            ////Если папка не пустая, необходимо указать параметр рекурсивного удаления - true:

            //Directory.Delete("C:\\myprogs\\testcsharp\\testfolder", recursive: true); ////удаление папки, и всего, что внутри 

            //Домашнее задание

            //Задача 1.Создайте файл numbers.txt и запишите в него натуральные числа от 1 до 500 через запятую.

            //StreamWriter writer = new StreamWriter(testfile, append: true);
            //for (int i = 1; i <= 500; i++)
            //{
            //    if (i == 500)
            //    {
            //        writer.Write(i + ".");
            //    }
            //    else
            //    {
            //        writer.Write(i + ",");
            //    }

            //}
            //writer.Close();

            //Задача 2.Дан массив строк: "red", "green", "black", "white", "blue".Запишите в файл элементы массива построчно(каждый элемент в новой строке).

            //string[] array = { "red", "green", "black", "white", "blue" };
            //StreamWriter writer = new StreamWriter(testfile);
            //foreach (string el in array)
            //{
            //    writer.WriteLine(el);
            //}
            //writer.Close();

            //Задача 3.Возьмите любой текстовый файл, и найдите в нем размер самой длинной строки.
            
            //Вспомним списки! ;)
            //StreamReader reader = new StreamReader(testfile);
            //List<string> list1 = new List<string> { };
            //while (!reader.EndOfStream)
            //{
            //    list1.Add(reader.ReadLine());
            //}
            //int maxlen = 0;
            //foreach (string str in list1)
            //{
            //    if (str.Length > maxlen)
            //    {
            //        maxlen = str.Length;
            //    }
            //}
            //reader.Close();
            //Console.WriteLine("Самая длинная строка содержит " + maxlen + " символов");
            //Console.ReadKey();
            
















        }
    }
}
