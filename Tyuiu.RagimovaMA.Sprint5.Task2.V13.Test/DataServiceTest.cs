using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.RagimovaMA.Sprint5.Task2.V13.Lib;

namespace Tyuiu.RagimovaMA.Sprint5.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Admin\source\repos\Tyuiu.RagimovaMA.Sprint5\Tyuiu.RagimovaMA.Sprint5.Task2.V13\bin\Debug\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}