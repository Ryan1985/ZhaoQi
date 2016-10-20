using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace ZhaoQi.Web.Core.Models
{
    [Table("ZHANGLI.HistoryData")]
    public class HistoryDataModel
    {
        public int ID { get; set; }
        [StringLength(50)]
        public string Can_Temp1_1 { get; set; }
        [StringLength(50)]
        public string Can_Temp1_2 { get; set; }
        [StringLength(50)]
        public string Can_Temp2_1 { get; set; }
        [StringLength(50)]
        public string Can_Temp2_2 { get; set; }
        [StringLength(50)]
        public string Can_Temp3_1 { get; set; }
        [StringLength(50)]
        public string Can_Temp3_2 { get; set; }
        [StringLength(50)]
        public string Can_Temp4_1 { get; set; }
        [StringLength(50)]
        public string Can_Temp4_2 { get; set; }
        [StringLength(50)]
        public string Can_Flow_Dry1 { get; set; }
        [StringLength(50)]
        public string Can_Flow_Wet1 { get; set; }
        [StringLength(50)]
        public string Can_Produce1 { get; set; }
        [StringLength(50)]
        public string Can_Flow_Dry2 { get; set; }
        [StringLength(50)]
        public string Can_Flow_Wet2 { get; set; }
        [StringLength(50)]
        public string Can_Produce2 { get; set; }
        [StringLength(50)]
        public string Can_Flow_Dry3 { get; set; }
        [StringLength(50)]
        public string Can_Flow_Wet3 { get; set; }
        [StringLength(50)]
        public string Can_Produce3 { get; set; }
        [StringLength(50)]
        public string Can_Flow_Dry4 { get; set; }
        [StringLength(50)]
        public string Can_Flow_Wet4 { get; set; }
        [StringLength(50)]
        public string Can_Produce4 { get; set; }
        [StringLength(50)]
        public string Can_Pressure { get; set; }
        [StringLength(50)]
        public string Store_Pressure { get; set; }
        [StringLength(50)]
        public string Supply_Flow { get; set; }
        [StringLength(50)]
        public string Supply_Pressure { get; set; }
        public DateTime UpdateTime { get; set; }



        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

    }
}
