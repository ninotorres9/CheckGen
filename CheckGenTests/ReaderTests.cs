using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckGen.Tests
{
    [TestClass()]
    public class ReaderTests
    {
        [TestMethod()]
        public void ReaderTest()
        {
            string filename = @"E:\\code\\CheckGen\\demo.xls";

            Reader reader = new Reader(filename);
            List<Item> result = reader.getResult();

            Assert.AreEqual(result[0].Type, "审批文件");
            Assert.AreEqual(result[0].Content, "发改委批复文件");
            Assert.AreEqual(result[0].IsPassed, false);
            Assert.AreEqual(result[0].Comment, "");

            Assert.AreEqual(result.Count, 29 + 16);
        }

        [TestMethod()]
        public void isDigitTest()
        {
            string number = "123";
            Assert.IsTrue(Reader.isDigit(number));
            string alpha = "abc";
            Assert.IsFalse(Reader.isDigit(alpha));
        }
    }
}