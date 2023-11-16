using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SavenkovaME.Sprint5.Task1.V10.Lib;
using System.IO;

namespace Tyuiu.SavenkovaME.Sprint5.Task1.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData()
        {
            string path = @"C:\Users\saven\source\repos\Tyuiu.SavenkovaME.Sprint5\Tyuiu.SavenkovaME.Sprint5.Task1.V10\bin\Debug\OutPutFileTask1.txt";
            FileInfo file = new FileInfo(path);
            bool exists = file.Exists;
            bool wait = true;
            Assert.AreEqual(wait, exists);
        }
    }
}
