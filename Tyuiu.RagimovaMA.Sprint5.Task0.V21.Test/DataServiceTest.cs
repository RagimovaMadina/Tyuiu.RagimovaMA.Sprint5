using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.RagimovaMA.Sprint5.Task0.V21.Lib;

namespace Tyuiu.RagimovaMA.Sprint5.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSave()
        {
            string path = @"C:\Users\Admin\source\repos\Tyuiu.RagimovaMA.Sprint5\Tyuiu.RagimovaMA.Sprint5.Task0.V21\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(fileExists, wait);
        }
    }
}
