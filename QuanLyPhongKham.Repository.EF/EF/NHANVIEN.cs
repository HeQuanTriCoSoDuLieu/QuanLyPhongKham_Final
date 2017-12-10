namespace QuanLyPhongKham.Repository.EF.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            PHIEUKHAMs = new HashSet<PHIEUKHAM>();
            PHIEUNHAPs = new HashSet<PHIEUNHAP>();
        }

        [Key]
        public int MANV { get; set; }

        [StringLength(50)]
        public string HOTEN { get; set; }

        public bool? GIOITINH { get; set; }

        [StringLength(20)]
        public string SODT { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        public int? MAKHOA { get; set; }

        public int? MACHUCDANH { get; set; }

        public int? MACHUCVU { get; set; }

        public virtual CHUCDANH CHUCDANH { get; set; }

        public virtual CHUCVU CHUCVU { get; set; }

        public virtual KHOA KHOA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUKHAM> PHIEUKHAMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUNHAP> PHIEUNHAPs { get; set; }
    }
}
