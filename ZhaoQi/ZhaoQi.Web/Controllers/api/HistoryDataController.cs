using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Newtonsoft.Json;
using ZhaoQi.Web.Core.Business;

namespace ZhaoQi.Web.Controllers.api
{
    public class HistoryDataController : ApiController
    {
        private BllHistoryData bll = new BllHistoryData();


        // GET api/historyData
        public string Get(string paramString)
        {
            try
            {
                var filters = JsonConvert.DeserializeObject<Hashtable>(paramString);
                var returnModels = bll.Query(filters);
                var returnValues = new Hashtable();
                foreach (var model in returnModels)
                {
                    returnValues.Add(model.Tag + int.Parse(model.ProjectId).ToString("00"), model);
                }

                return JsonConvert.SerializeObject(returnValues);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }



        // POST api/realdata
        public void Post([FromBody]string value)
        {
        }

        // PUT api/realdata/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/realdata/5
        public void Delete(int id)
        {
        }
    }
}