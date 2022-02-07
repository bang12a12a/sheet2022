namespace PianoSheet.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Banner")]
    public partial class Banner
    {
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(500)]
        public string TenAnh { get; set; }

        public string MoTa { get; set; }

        public int? TrangThai { get; set; }
    }
}
