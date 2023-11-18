using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SavenkovaME.Sprint5.Task3.V28.Lib;
using System.IO;

namespace Tyuiu.SavenkovaME.Sprint5.Task3.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData()
        {
            string path = @"C:\Users\saven\source\repos\Tyuiu.SavenkovaME.Sprint5\Tyuiu.SavenkovaME.Sprint5.Task3.V28\bin\Debug\OutPutFileTask3.bin";
            FileInfo file = new FileInfo(path);
            bool exists = file.Exists;
            bool wait = true;
            Assert.AreEqual(wait, exists);
        }
    }
}
