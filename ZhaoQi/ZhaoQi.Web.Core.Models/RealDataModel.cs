namespace ZhaoQi.Web.Core.Models
{
    public class RealDataModel
    {
        public string Id { get; set; }
        public string Tag { get; set; }
        public string TagValue { get; set; }
        public string ProjectId { get; set; }
        public string TagUnit { get; set; }
        public string TagDesc { get; set; }
        public string UpdateTime { get; set; }

        public override bool Equals(object obj)
        {
            return Id.Equals(obj.ToString(), System.StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
