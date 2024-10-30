namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThanhToan")]
    public partial class ThanhToan
    {
        public int Id { get; set; }

        public int? IdDonHang { get; set; }

        [Required]
        [StringLength(50)]
        public string HinhThucThanhToan { get; set; }

        public DateTime NgayThanhToan { get; set; }

        public decimal SoTien { get; set; }

        public virtual DonHang DonHang { get; set; }
    }
}
