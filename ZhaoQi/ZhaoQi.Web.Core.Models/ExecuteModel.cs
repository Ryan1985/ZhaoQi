using System;

namespace ZhaoQi.Web.Core.Models
{
    public class ExecuteModel
    {
        public string Id { get; set; }
        public string Tag { get; set; }
        public string TagValue { get; set; }
        public string ProjectId { get; set; }
        public string TagUnit { get; set; }
        public string TagDesc { get; set; }
        public string UpdateTime { get; set; }
        public string Flag { get; set; }
        public string ExecuteTime { get; set; }


        public override bool Equals(object obj)
        {
            return obj != null && this.Id.Equals(((ExecuteModel) obj).Id, StringComparison.CurrentCultureIgnoreCase);
        }



    }
}
