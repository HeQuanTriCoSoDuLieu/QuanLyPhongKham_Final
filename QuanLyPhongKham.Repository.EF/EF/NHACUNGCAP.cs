namespace QuanLyPhongKham.Repository.EF.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHACUNGCAP")]
    public partial class NHACUNGCAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHACUNGCAP()
        {
            CHITIETNHAPVATTUs = new HashSet<CHITIETNHAPVATTU>();
            CHITIETPHIEUNHAPTHUOCs = new HashSet<CHITIETPHIEUNHAPTHUOC>();
        }

        [Key]
        public int MANHACC { get; set; }

        [StringLength(100)]
        public string TENNHACC { get; set; }

        [StringLength(100)]
        public string DIACHI { get; set; }

        [StringLength(20)]
        public string SODT { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        public int? MAQUOCGIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETNHAPVATTU> CHITIETNHAPVATTUs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETPHIEUNHAPTHUOC> CHITIETPHIEUNHAPTHUOCs { get; set; }

        public virtual QUOCGIA QUOCGIA { get; set; }
    }
}
