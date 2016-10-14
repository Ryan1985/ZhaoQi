using System;
using System.Collections;
using System.Web.Http;
using Newtonsoft.Json;
using ZhaoQi.Web.Core.Business;

namespace ZhaoQi.Web.Controllers.api
{
    public class RealDataController : ApiController
    {
        private BllRealData bll = new BllRealData();


        // GET api/realdata
        public string Get()
        {
            try
            {

                var returnModels = bll.Query(null);
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

        // GET api/realdata/5
        public string Get(int id)
        {
            return "value";
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
