using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.RagimovaMA.Sprint5.Task3.V9.Lib;

namespace Tyuiu.RagimovaMA.Sprint5.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test3()
        {
            string path = @"C:\Users\Admin\source\repos\Tyuiu.RagimovaMA.Sprint5\Tyuiu.RagimovaMA.Sprint5.Task3.V9\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileinfo = new FileInfo(path);
            bool fileex = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileex);
        }
    }
}
