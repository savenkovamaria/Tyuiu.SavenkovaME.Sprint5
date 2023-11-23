﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SavenkovaME.Sprint5.Task6.V5.Lib;
using System.IO;

namespace Tyuiu.SavenkovaME.Sprint5.Task6.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Савенкова М. Е. | ИИПб-23-2";
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                     *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                              *");
            Console.WriteLine("* Задание #6                                                                    *");
            Console.WriteLine("* Вариант #5                                                                    *");
            Console.WriteLine("* Выполнила Савенкова М. Е. | ИИПб-23-2                                         *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                      *");
            Console.WriteLine("* Дан файл в котором есть набор символьных данных. Найти количество заглавных   *");
            Console.WriteLine("* латинских букв в заданной строке.                                             *");
            Console.WriteLine("*                                                                               *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                              *");
            Console.WriteLine("*********************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask6V5.txt";
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
