namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaoCaoDoanhThu")]
    public partial class BaoCaoDoanhThu
    {
        public int Id { get; set; }

        public int Thang { get; set; }

        public int Nam { get; set; }

        public decimal TongDoanhThu { get; set; }
    }
}
