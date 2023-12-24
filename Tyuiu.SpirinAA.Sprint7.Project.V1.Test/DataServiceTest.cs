using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SpirinAA.Sprint7.Project.V1.Lib;

namespace Tyuiu.SpirinAA.Sprint7.Project.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Утверждение
            string testFilePath = @"C:\DataSprint7\InPutFileTask7V1.csv";

            int lineCount = 0;

            using (var reader = new StreamReader(testFilePath))
            {
                // Пропускаем заголовок
                reader.ReadLine();

                // Считаем оставшиеся строки
                while (reader.ReadLine() != null)
                {
                    lineCount++;
                }
            }
            Assert.AreEqual(10, lineCount);
        }
    }
}
