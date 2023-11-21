using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SavenkovaME.Sprint5.Task4.V9.Lib;
using System.IO;

namespace Tyuiu.SavenkovaME.Sprint5.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V9.txt";
            FileInfo file = new FileInfo(path);
            bool exists = file.Exists;
            bool wait = true;
            Assert.AreEqual(wait, exists); 
        }
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask4V9.txt";
            double res = ds.LoadFromDataFile(path);
            double wait = 7.57;
            Assert.AreEqual(wait, res);
        }
    }
}
