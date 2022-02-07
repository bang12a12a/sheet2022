using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PianoSheet.Models.Models
{
    public class SanPhamModel
    {
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

        public string Url { get; set; }

        public int? TrangThai { get; set; }
    }
}