using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SavenkovaME.Sprint5.Task5.V12.Lib;
using System.IO;

namespace Tyuiu.SavenkovaME.Sprint5.Task5.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Савенкова М. Е. | ИИПб-23-2";
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                     *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                                *");
            Console.WriteLine("* Задание #5                                                                    *");
            Console.WriteLine("* Вариант #12                                                                   *");
            Console.WriteLine("* Выполнила Савенкова М. Е. | ИИПб-23-2                                         *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                      *");
            Console.WriteLine("* Дан файл в котором есть набор значений. Найти разницу между суммой всех       *");
            Console.WriteLine("* положительных и отрицательных целых чисел в файле. Полученный результат вывес-*");
            Console.WriteLine("* ти на консоль. У вещественных значений округлить до 3 знаков после запятой.   *");
            Console.WriteLine("*                                                                               *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                              *");
            Console.WriteLine("*********************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask5V12.txt";
            Console.WriteLine("Данные из файла: " + path);
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                    *");
            Console.WriteLine("*********************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
