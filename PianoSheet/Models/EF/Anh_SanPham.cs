namespace PianoSheet.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Anh_SanPham
    {
        [StringLength(20)]
        public string Id { get; set; }

        [StringLength(20)]
        public string IdSanPham { get; set; }

        public string DuongDan { get; set; }
    }
}
