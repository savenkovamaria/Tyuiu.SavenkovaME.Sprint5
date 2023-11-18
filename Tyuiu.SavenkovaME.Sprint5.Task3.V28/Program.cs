using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SavenkovaME.Sprint5.Task3.V28.Lib;
using System.IO;

namespace Tyuiu.SavenkovaME.Sprint5.Task3.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Савенкова М. Е. | ИИПб-23-2";
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                     *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                           *");
            Console.WriteLine("* Задание #3                                                                    *");
            Console.WriteLine("* Вариант #28                                                                   *");
            Console.WriteLine("* Выполнила Савенкова М. Е. | ИИПб-23-2                                         *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                      *");
            Console.WriteLine("* Дано выражение вычислить его значение при x=3, результат сохранить в бинарный *");
            Console.WriteLine("* файл OutPutFileTask3.bin и вывести на консоль. Округлить до 3 знаков после ,. *");
            Console.WriteLine("*        1                                                                      *");
            Console.WriteLine("*  y = - - (x^3 - 3x^2 + 4)                                                     *");
            Console.WriteLine("*        4                                                                      *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                              *");
            Console.WriteLine("*********************************************************************************");
            int x = 3;
            Console.WriteLine("" + x);

            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                    *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
