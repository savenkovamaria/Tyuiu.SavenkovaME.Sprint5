using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SavenkovaME.Sprint5.Task1.V10.Lib;
using System.IO;

namespace Tyuiu.SavenkovaME.Sprint5.Task1.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Савенкова М. Е. | ИИПб-23-2";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                      *");
            Console.WriteLine("* Задание #1                                                                   *");
            Console.WriteLine("* Вариант #10                                                                  *");
            Console.WriteLine("* Выполнила Савенкова М. Е. | ИИПб-23-2                                        *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дана функция, произвести табулирование f(x) на заданном диапазоне [-5;5] с   *");
            Console.WriteLine("* шагом 1. Округлить до 2 знаков после запятой.                                *");
            Console.WriteLine("*         2cos(x) + 2                                                          *");
            Console.WriteLine("*  f(x) = ----------- + cos(x) - 5x + 3                                        *");
            Console.WriteLine("*           2x - 1                                                             *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            int start = -5;
            int stop = 5;
            Console.WriteLine("Начало шага = " + start);
            Console.WriteLine("Конец шага = " + stop);
            string res = ds.SaveToFileTextData(start, stop);
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
