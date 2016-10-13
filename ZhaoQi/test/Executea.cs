namespace test
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZHANGLI.Executea")]
    public partial class Executea
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Tag { get; set; }

        [StringLength(50)]
        public string TagValue { get; set; }

        [StringLength(50)]
        public string ProjectID { get; set; }

        [StringLength(50)]
        public string TagUint { get; set; }

        [StringLength(50)]
        public string TagDesc { get; set; }

        [StringLength(50)]
        public string UpdateTime { get; set; }

        [StringLength(50)]
        public string Flag { get; set; }

        [StringLength(50)]
        public string ExecuteTime { get; set; }
    }
}
