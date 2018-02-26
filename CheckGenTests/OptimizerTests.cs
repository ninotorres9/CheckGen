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
    public class OptimizerTests
    {
        [TestMethod()]
        public void OptimizerTest()
        {
            var source = new List<Item>
            {
                new Item("审批文件", "可研报告", true, "我是备注"),
                new Item("审批文件", "工程规划许可证", false, "我是备注"),
            };
            var optimizer = new Optimizer(source);
            var result = optimizer.getResult();

            Assert.AreEqual(result.Count(), 1);
            Assert.AreEqual(result[0].Content, "工程规划许可证");
        }
    }
}