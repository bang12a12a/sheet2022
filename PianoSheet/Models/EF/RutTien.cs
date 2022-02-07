namespace PianoSheet.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RutTien")]
    public partial class RutTien
    {
        [StringLength(50)]
        public string Id { get; set; }

        public DateTime? NgayRut { get; set; }

        public decimal? SoTien { get; set; }

        [StringLength(50)]
        public string IdNguoiDung { get; set; }

        [StringLength(50)]
        public string EmailPaypal { get; set; }

        [StringLength(500)]
        public string NganHang { get; set; }

        [StringLength(50)]
        public string SoTaiKhoan { get; set; }

        public int? KieuRut { get; set; }

        [StringLength(50)]
        public string ChuTaiKhoan { get; set; }

        public int? TrangThai { get; set; }

        public int? SoTienVN { get; set; }
    }
}
