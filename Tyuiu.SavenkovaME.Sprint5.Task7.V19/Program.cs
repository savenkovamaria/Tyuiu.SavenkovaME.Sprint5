using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SavenkovaME.Sprint5.Task7.V19.Lib;
using System.IO;

namespace Tyuiu.SavenkovaME.Sprint5.Task7.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Савенкова М. Е. | ИИПб-23-2";
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                     *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                       *");
            Console.WriteLine("* Задание #7                                                                    *");
            Console.WriteLine("* Вариант #19                                                                   *");
            Console.WriteLine("* Выполнила Савенкова М. Е. | ИИПб-23-2                                         *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                      *");
            Console.WriteLine("* Дан файл в котором есть набор символьных данных. Удалить все удвоенные буквы  *");
            Console.WriteLine("* сс из файла.Полученный результат сохранить в файл OutPutDataFileTask7V19.txt. *");
            Console.WriteLine("*                                                                               *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                              *");
            Console.WriteLine("*********************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask7V19.txt";
            string pathSave = @"C:\DataSprint5\OutPutDataFileTask7V19.txt";
            Console.WriteLine("Данные из файла: " + path);
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                    *");
            Console.WriteLine("*********************************************************************************");
            pathSave = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSave);
            Console.ReadKey();
        }
    }
}
