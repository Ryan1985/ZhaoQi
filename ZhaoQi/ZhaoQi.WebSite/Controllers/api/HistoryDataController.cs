using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using ZhaoQi.Web.Core.Business;
using ZhaoQi.Web.Core.Models;

namespace ZhaoQi.WebSite.Controllers.api
{
    public class HistoryDataController : ApiController
    {
        private BllHistoryData bll = new BllHistoryData();
        // GET: api/HistoryData
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/HistoryData/5
        public IEnumerable<HistoryDataModel> Get(string filterString)
        {
            var htFilters = JsonConvert.DeserializeObject<Hashtable>(filterString);
            var result = bll.Query(htFilters);
            return result;
        }

        // POST: api/HistoryData
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/HistoryData/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/HistoryData/5
        public void Delete(int id)
        {
        }
    }
}
