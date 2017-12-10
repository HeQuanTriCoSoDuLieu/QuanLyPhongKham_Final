using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using QuanLyPhongKham.Model.DTO;
namespace QuanLyPhongKham.Repositories.EF
{
    class QuanLyPhongKhamDbContext : DbContext
    {
        #region Singleton pattern

        /// <summary>
        /// private instance
        /// </summary>
        private static QuanLyPhongKhamDbContext instance;

        /// <summary>
        /// private constuctor
        /// </summary>
        private QuanLyPhongKhamDbContext()
            : base("name=QuanLyPhongKhamDbContext")
        {
        }

        /// <summary>
        /// public Instance để thực thi câu lệnh
        /// </summary>
        public static QuanLyPhongKhamDbContext Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new QuanLyPhongKhamDbContext();
                }
                return instance;
            }
        }

        #endregion

        //public virtual DbSet<BenhNhan> BENHNHANs { get; set; }
        //public virtual DbSet<CANLAMSANG> CANLAMSANGs { get; set; }
        //public virtual DbSet<CHITIETCL> CHITIETCLS { get; set; }
        //public virtual DbSet<CHITIETDONTHUOC> CHITIETDONTHUOCs { get; set; }
        //public virtual DbSet<CHITIETNHAPVATTU> CHITIETNHAPVATTUs { get; set; }
        //public virtual DbSet<CHITIETPHIEUNHAPTHUOC> CHITIETPHIEUNHAPTHUOCs { get; set; }
        //public virtual DbSet<CHUCDANH> CHUCDANHs { get; set; }
        //public virtual DbSet<CHUCVU> CHUCVUs { get; set; }
        //public virtual DbSet<DICHVUCL> DICHVUCLS { get; set; }
        //public virtual DbSet<DONTHUOC> DONTHUOCs { get; set; }
        //public virtual DbSet<DONVITINH> DONVITINHs { get; set; }
        //public virtual DbSet<HANGSANXUAT> HANGSANXUATs { get; set; }
        //public virtual DbSet<HINHTHUCKHAM> HINHTHUCKHAMs { get; set; }
        //public virtual DbSet<HOADON> HOADONs { get; set; }
        //public virtual DbSet<KHOA> KHOAs { get; set; }
        //public virtual DbSet<LOAICANLAMSANG> LOAICANLAMSANGs { get; set; }
        //public virtual DbSet<LOAITHUOC> LOAITHUOCs { get; set; }
        //public virtual DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        //public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        //public virtual DbSet<PHANQUYEN> PHANQUYENs { get; set; }
        //public virtual DbSet<PHIEUKHAM> PHIEUKHAMs { get; set; }
        //public virtual DbSet<PHIEUNHAP> PHIEUNHAPs { get; set; }
        //public virtual DbSet<QUOCGIA> QUOCGIAs { get; set; }
        public virtual DbSet<TaiKhoan> TAIKHOAN { get; set; }
        //public virtual DbSet<THUOC> THUOCs { get; set; }
        //public virtual DbSet<VATTUYTE> VATTUYTEs { get; set; }

    //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Entity<BENHNHAN>()
    //            .Property(e => e.SODT)
    //            .IsUnicode(false);

    //        modelBuilder.Entity<CANLAMSANG>()
    //            .Property(e => e.GIATIEN)
    //            .HasPrecision(19, 4);

    //        modelBuilder.Entity<CANLAMSANG>()
    //            .HasMany(e => e.CHITIETCLS)
    //            .WithRequired(e => e.CANLAMSANG)
    //            .WillCascadeOnDelete(false);

    //        modelBuilder.Entity<CHITIETCL>()
    //            .Property(e => e.KETQUA)
    //            .IsUnicode(false);

    //        modelBuilder.Entity<CHITIETDONTHUOC>()
    //            .Property(e => e.HUONGDAN)
    //            .IsUnicode(false);

    //        modelBuilder.Entity<CHITIETNHAPVATTU>()
    //            .Property(e => e.GIANHAP)
    //            .HasPrecision(19, 4);

    //        modelBuilder.Entity<CHITIETPHIEUNHAPTHUOC>()
    //            .Property(e => e.GIANHAP)
    //            .HasPrecision(19, 4);

    //        modelBuilder.Entity<CHITIETPHIEUNHAPTHUOC>()
    //            .Property(e => e.GIABANLE)
    //            .HasPrecision(19, 4);

    //        modelBuilder.Entity<DICHVUCL>()
    //            .Property(e => e.TONGCONG)
    //            .HasPrecision(19, 4);

    //        modelBuilder.Entity<DICHVUCL>()
    //            .HasMany(e => e.CHITIETCLS)
    //            .WithRequired(e => e.DICHVUCL)
    //            .WillCascadeOnDelete(false);

    //        modelBuilder.Entity<DONTHUOC>()
    //            .Property(e => e.TONGCONG)
    //            .HasPrecision(19, 4);

    //        modelBuilder.Entity<DONTHUOC>()
    //            .HasMany(e => e.CHITIETDONTHUOCs)
    //            .WithRequired(e => e.DONTHUOC)
    //            .WillCascadeOnDelete(false);

    //        modelBuilder.Entity<DONVITINH>()
    //            .HasMany(e => e.THUOCs)
    //            .WithOptional(e => e.DONVITINH1)
    //            .HasForeignKey(e => e.DONVITINH);

    //        modelBuilder.Entity<HOADON>()
    //            .Property(e => e.TONGCONG)
    //            .HasPrecision(19, 4);

    //        modelBuilder.Entity<LOAITHUOC>()
    //            .HasMany(e => e.THUOCs)
    //            .WithOptional(e => e.LOAITHUOC1)
    //            .HasForeignKey(e => e.LOAITHUOC);

    //        modelBuilder.Entity<NHACUNGCAP>()
    //            .Property(e => e.SODT)
    //            .IsUnicode(false);

    //        modelBuilder.Entity<NHANVIEN>()
    //            .Property(e => e.SODT)
    //            .IsUnicode(false);

    //        modelBuilder.Entity<NHANVIEN>()
    //            .Property(e => e.EMAIL)
    //            .IsUnicode(false);

    //        modelBuilder.Entity<PHIEUKHAM>()
    //            .HasMany(e => e.DONTHUOCs)
    //            .WithRequired(e => e.PHIEUKHAM)
    //            .WillCascadeOnDelete(false);

    //        modelBuilder.Entity<PHIEUKHAM>()
    //            .HasMany(e => e.HOADONs)
    //            .WithRequired(e => e.PHIEUKHAM)
    //            .WillCascadeOnDelete(false);

    //        modelBuilder.Entity<PHIEUNHAP>()
    //            .HasMany(e => e.CHITIETNHAPVATTUs)
    //            .WithRequired(e => e.PHIEUNHAP)
    //            .WillCascadeOnDelete(false);

    //        modelBuilder.Entity<PHIEUNHAP>()
    //            .HasMany(e => e.CHITIETPHIEUNHAPTHUOCs)
    //            .WithRequired(e => e.PHIEUNHAP)
    //            .WillCascadeOnDelete(false);

    //        modelBuilder.Entity<TAIKHOAN>()
    //            .Property(e => e.TENDANGNHAP)
    //            .IsUnicode(false);

    //        modelBuilder.Entity<TAIKHOAN>()
    //            .Property(e => e.MATKHAU)
    //            .IsUnicode(false);

    //        modelBuilder.Entity<THUOC>()
    //            .Property(e => e.GHICHU)
    //            .IsUnicode(false);

    //        modelBuilder.Entity<THUOC>()
    //            .HasMany(e => e.CHITIETDONTHUOCs)
    //            .WithRequired(e => e.THUOC)
    //            .WillCascadeOnDelete(false);

    //        modelBuilder.Entity<THUOC>()
    //            .HasMany(e => e.CHITIETPHIEUNHAPTHUOCs)
    //            .WithRequired(e => e.THUOC)
    //            .WillCascadeOnDelete(false);

    //        modelBuilder.Entity<VATTUYTE>()
    //            .HasMany(e => e.CHITIETNHAPVATTUs)
    //            .WithRequired(e => e.VATTUYTE)
    //            .WillCascadeOnDelete(false);
    //    }
    //}

}
}
