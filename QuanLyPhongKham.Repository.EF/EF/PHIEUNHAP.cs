namespace QuanLyPhongKham.Repository.EF.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUNHAP")]
    public partial class PHIEUNHAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUNHAP()
        {
            CHITIETNHAPVATTUs = new HashSet<CHITIETNHAPVATTU>();
            CHITIETPHIEUNHAPTHUOCs = new HashSet<CHITIETPHIEUNHAPTHUOC>();
        }

        [Key]
        public int MAPHIEUNHAP { get; set; }

        public int? MANV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYNHAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETNHAPVATTU> CHITIETNHAPVATTUs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETPHIEUNHAPTHUOC> CHITIETPHIEUNHAPTHUOCs { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
