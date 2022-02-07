namespace PianoSheet.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [StringLength(50)]
        public string Id { get; set; }

        public string Ten { get; set; }

        public string Anh { get; set; }

        public string Video { get; set; }

        public string MoTa { get; set; }

        public DateTime? Ngay { get; set; }

        public string DuongDanFileMidi { get; set; }

        public string DuongDan { get; set; }

        public int? SoTrang { get; set; }

        public string DuongDanFileMp3 { get; set; }

        [StringLength(500)]
        public string Url { get; set; }

        public int? TrangThai { get; set; }
    }
}
