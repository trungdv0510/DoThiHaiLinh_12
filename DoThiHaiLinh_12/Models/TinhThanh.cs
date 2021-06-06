namespace DoThiHaiLinh_12.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TinhThanh")]
    public partial class TinhThanh
    {
        [Key]
        public int MaTinhThanh { get; set; }

        [StringLength(50)]
        public string TenTinhThanh { get; set; }
    }
}
