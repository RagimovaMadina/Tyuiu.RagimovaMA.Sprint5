using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.RagimovaMA.Sprint5.Task5.V24.Lib;

namespace Tyuiu.RagimovaMA.Sprint5.Task5.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V24.txt";

            FileInfo info = new FileInfo(path);
            bool res = info.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
