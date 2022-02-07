using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PianoSheet.Models.EF
{
    public partial class MyMusicSheetEntities : DbContext
    {
        public MyMusicSheetEntities()
            : base("name=MyMusicSheetEntities")
        {
        }

        public virtual DbSet<Anh_SanPham> Anh_SanPham { get; set; }
        public virtual DbSet<Banner> Banners { get; set; }
        public virtual DbSet<GioHang> GioHangs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<Loai> Loais { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<RutTien> RutTiens { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<SanPham_Loai> SanPham_Loai { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Anh_SanPham>()
                .Property(e => e.Id)
                .IsFixedLength();

            modelBuilder.Entity<Anh_SanPham>()
                .Property(e => e.IdSanPham)
                .IsFixedLength();

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.Gia)
                .HasPrecision(5, 2);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.SoDu)
                .HasPrecision(5, 2);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<RutTien>()
                .Property(e => e.SoTien)
                .HasPrecision(15, 2);
        }
    }
}
