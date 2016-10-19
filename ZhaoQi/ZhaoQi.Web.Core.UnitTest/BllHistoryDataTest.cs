using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZhaoQi.Web.Core.Business;
using ZhaoQi.Web.Core.Models;
using ZhaoQi.Web.Core.Repository.Fakes;

namespace ZhaoQi.Web.Core.UnitTest
{
    [TestClass]
    public class BllHistoryDataTest
    {
        [TestMethod]
        public void GetHisDataTest()
        {
            var rep = new StubIRepository<HistoryDataModel>();
            rep.QueryGet = () =>
            {
                var simData = new List<HistoryDataModel>();
                for (var i = 0; i < 10; i++)
                {
                    simData.Add(new HistoryDataModel
                    {
                        ID = i,
                        Can_Temp1_1 = "Can_Temp1_1" + i,
                        Can_Temp1_2 = "Can_Temp1_2" + i,
                        Can_Temp2_1 = "Can_Temp2_1" + i,
                        Can_Temp2_2 = "Can_Temp2_2" + i,
                        Can_Temp3_1 = "Can_Temp3_1" + i,
                        Can_Temp3_2 = "Can_Temp3_2" + i,
                        Can_Temp4_1 = "Can_Temp4_1" + i,
                        Can_Temp4_2 = "Can_Temp4_2" + i,
                        Can_Flow_Dry1 = "Can_Flow_Dry1" + i,
                        Can_Flow_Wet1 = "Can_Flow_Wet1" + i,
                        Can_Produce1 = "Can_Produce1" + i,
                        Can_Flow_Dry2 = "Can_Flow_Dry2" + i,
                        Can_Flow_Wet2 = "Can_Flow_Wet2" + i,
                        Can_Produce2 = "Can_Produce2" + i,
                        Can_Flow_Dry3 = "Can_Flow_Dry3" + i,
                        Can_Flow_Wet3 = "Can_Flow_Wet3" + i,
                        Can_Produce3 = "Can_Produce3" + i,
                        Can_Flow_Dry4 = "Can_Flow_Dry4" + i,
                        Can_Flow_Wet4 = "Can_Flow_Wet4" + i,
                        Can_Produce4 = "Can_Produce4" + i,
                        Can_Pressure = "Can_Pressure" + i,
                        Store_Pressure = "Store_Pressure" + i,
                        Supply_Flow = "Supply_Flow" + i,
                        Supply_Pressure = "Supply_Pressure" + i,
                        UpdateTime =DateTime.Now,
                    });
                }
                return simData.AsQueryable();
            };


            var bll = new BllHistoryData(rep);
            var queryResult = bll.Query(null);
            Assert.AreEqual(10, queryResult.Count);
        }


        [TestMethod]
        public void GetHisDataTestWithFilter()
        {
            var rep = new StubIRepository<HistoryDataModel>();
            rep.QueryGet = () =>
            {
                var simData = new List<HistoryDataModel>();
                for (var i = 0; i < 10; i++)
                {
                    simData.Add(new HistoryDataModel
                    {
                        ID = i,
                        Can_Temp1_1 = "Can_Temp1_1" + i,
                        Can_Temp1_2 = "Can_Temp1_2" + i,
                        Can_Temp2_1 = "Can_Temp2_1" + i,
                        Can_Temp2_2 = "Can_Temp2_2" + i,
                        Can_Temp3_1 = "Can_Temp3_1" + i,
                        Can_Temp3_2 = "Can_Temp3_2" + i,
                        Can_Temp4_1 = "Can_Temp4_1" + i,
                        Can_Temp4_2 = "Can_Temp4_2" + i,
                        Can_Flow_Dry1 = "Can_Flow_Dry1" + i,
                        Can_Flow_Wet1 = "Can_Flow_Wet1" + i,
                        Can_Produce1 = "Can_Produce1" + i,
                        Can_Flow_Dry2 = "Can_Flow_Dry2" + i,
                        Can_Flow_Wet2 = "Can_Flow_Wet2" + i,
                        Can_Produce2 = "Can_Produce2" + i,
                        Can_Flow_Dry3 = "Can_Flow_Dry3" + i,
                        Can_Flow_Wet3 = "Can_Flow_Wet3" + i,
                        Can_Produce3 = "Can_Produce3" + i,
                        Can_Flow_Dry4 = "Can_Flow_Dry4" + i,
                        Can_Flow_Wet4 = "Can_Flow_Wet4" + i,
                        Can_Produce4 = "Can_Produce4" + i,
                        Can_Pressure = "Can_Pressure" + i,
                        Store_Pressure = "Store_Pressure" + i,
                        Supply_Flow = "Supply_Flow" + i,
                        Supply_Pressure = "Supply_Pressure" + i,
                        UpdateTime = DateTime.Now,
                    });
                }
                return simData.AsQueryable();
            };


            var bll = new BllHistoryData(rep);
            var queryResult = bll.Query(new Hashtable
            {
                {"ID","0"}
            });
            Assert.AreEqual(1, queryResult.Count);

        }
    }
}
