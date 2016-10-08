using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZhaoQi.BLL;
using ZhaoQi.BLL.BizProcess;
using ZhaoQi.Model;

namespace ZhaoQi.Test.BLL
{
    [TestClass]
    public class BllExecuteTest
    {
        [TestMethod]
        public void TestAddExecuteSuccess()
        {
            var bllExecute = new BllExecute();

            var testModels = new List<ExecuteModel>();
            testModels.Add(new ExecuteModel
            {
                ExecuteTime = null,
                Flag = "1",
                Id = "0",
                ProjectId = "1",
                Tag = "4001",
                TagDesc = "管体温度1",
                TagUnit = "度",
                TagValue = "30",
                UpdateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            });


            var result = bllExecute.Add(testModels);

            Assert.AreEqual(string.Empty, result);
        }
    }
}
