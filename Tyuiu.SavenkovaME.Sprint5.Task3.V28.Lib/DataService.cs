using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.SavenkovaME.Sprint5.Task3.V28.Lib
{
    public class DataService : ISprint5Task3V28
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.bin";
            double y = -0.25 * (Math.Pow((double)x, 3) - 3 * Math.Pow((double)x, 2) + 4);
            y = Math.Round(y, 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }
            return path;
        }
    }

}
    
