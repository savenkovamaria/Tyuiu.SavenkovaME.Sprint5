using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.SavenkovaME.Sprint5.Task4.V9.Lib
{
    public class DataService : ISprint5Task4V9
    {
        public double LoadFromDataFile(string path)
        {
            string strY = File.ReadAllText(path);
            double x = Convert.ToDouble(strY);
            double res = Math.Round(((1 / Math.Sin(x)) + Math.Pow(x, 2)), 3);
            return res;
        }
    }
}
