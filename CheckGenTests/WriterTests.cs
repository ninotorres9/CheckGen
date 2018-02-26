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
    public class WriterTests
    {
        [TestMethod()]
        public void toStringTest()
        {
            Item item = new Item("审批文件", "可研报告", true, "我是备注");
            Assert.AreEqual(item.toString(),
                "| 审批文件 | 可研报告 | 我是备注 |");
        }

        [TestMethod()]
        public void writerTest()
        {
            var source = new List<Item>
            {
                new Item("审批文件", "可研报告", true, "我是备注"),
                new Item("审批文件", "工程规划许可证", false, "我是备注"),
            };
            var fileName = "D:\\code\\CheckGen\\CheckGenTests\\demo.md";
            Writer writer = new Writer(source, fileName);
            writer.toFile();
        }
    }
}