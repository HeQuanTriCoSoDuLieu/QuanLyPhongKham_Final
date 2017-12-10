namespace QuanLyPhongKham.Repository.EF.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THUOC")]
    public partial class THUOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THUOC()
        {
            CHITIETDONTHUOCs = new HashSet<CHITIETDONTHUOC>();
            CHITIETPHIEUNHAPTHUOCs = new HashSet<CHITIETPHIEUNHAPTHUOC>();
        }

        [Key]
        public int MATHUOC { get; set; }

        [Required]
        [StringLength(50)]
        public string TENTHUOC { get; set; }

        public int? DONVITINH { get; set; }

        public int? LOAITHUOC { get; set; }

        public int? SOLUONGTON { get; set; }

        [Column(TypeName = "text")]
        public string GHICHU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDONTHUOC> CHITIETDONTHUOCs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETPHIEUNHAPTHUOC> CHITIETPHIEUNHAPTHUOCs { get; set; }

        public virtual DONVITINH DONVITINH1 { get; set; }

        public virtual LOAITHUOC LOAITHUOC1 { get; set; }
    }
}
