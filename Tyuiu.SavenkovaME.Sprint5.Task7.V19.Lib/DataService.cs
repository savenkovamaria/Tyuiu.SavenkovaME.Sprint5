using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.SavenkovaME.Sprint5.Task7.V19.Lib
{
    public class DataService : ISprint5Task7V19
    {
        public string LoadDataAndSave(string path)
        {
            string pathSave = @"C:\DataSprint5\OutPutDataFileTask7V19.txt";
            FileInfo fileinfo = new FileInfo(pathSave);
            bool exists = fileinfo.Exists;

            if (exists)
            {
                File.Delete(pathSave);
            }

            string str = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    str = line.Replace("сс", "").Replace("Сс","");   
                }
                File.AppendAllText(pathSave, str + Environment.NewLine);
            }
            return pathSave;
        }
    }
}
