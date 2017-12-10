namespace QuanLyPhongKham.Repository.EF.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUKHAM")]
    public partial class PHIEUKHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUKHAM()
        {
            DICHVUCLS = new HashSet<DICHVUCL>();
            DONTHUOCs = new HashSet<DONTHUOC>();
            HOADONs = new HashSet<HOADON>();
        }

        [Key]
        public int MAPHIEUKHAM { get; set; }

        public int? MABN { get; set; }

        public int? MANV { get; set; }

        [StringLength(250)]
        public string CHUANDOAN { get; set; }

        public int? MAHINHTHUCKHAM { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYKHAM { get; set; }

        [StringLength(50)]
        public string KETLUAN { get; set; }

        public bool? HOANTHANH { get; set; }

        public bool? DATHANHTOAN { get; set; }

        public virtual BENHNHAN BENHNHAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DICHVUCL> DICHVUCLS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONTHUOC> DONTHUOCs { get; set; }

        public virtual HINHTHUCKHAM HINHTHUCKHAM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
