namespace PianoSheet.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(50)]
        public string IdNguoiDung { get; set; }

        [StringLength(50)]
        public string IdSanPham { get; set; }

        public decimal? Gia { get; set; }

        public DateTime? Ngay { get; set; }
    }
}
