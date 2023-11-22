using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.SavenkovaME.Sprint5.Task5.V12.Lib
{
    public class DataService : ISprint5Task5V12
    {
        public double LoadFromDataFile(string path)
        {
            double plus = 0;
            double minus = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (Convert.ToDouble(line) > 0)
                    {
                        plus += Convert.ToDouble(line);
                    }
                    else
                    {
                        minus += Convert.ToDouble(line);
                    }
                }
            }
            return Math.Round(Math.Abs(plus - minus), 3);
        }
    }
}
