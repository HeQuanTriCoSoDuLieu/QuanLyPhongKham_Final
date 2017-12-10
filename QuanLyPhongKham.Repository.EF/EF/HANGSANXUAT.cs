namespace QuanLyPhongKham.Repository.EF.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HANGSANXUAT")]
    public partial class HANGSANXUAT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HANGSANXUAT()
        {
            CHITIETNHAPVATTUs = new HashSet<CHITIETNHAPVATTU>();
            CHITIETPHIEUNHAPTHUOCs = new HashSet<CHITIETPHIEUNHAPTHUOC>();
        }

        [Key]
        public int MAHSX { get; set; }

        [StringLength(100)]
        public string TENHSX { get; set; }

        [StringLength(250)]
        public string DIACHI { get; set; }

        public int? MAQUOCGIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETNHAPVATTU> CHITIETNHAPVATTUs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETPHIEUNHAPTHUOC> CHITIETPHIEUNHAPTHUOCs { get; set; }

        public virtual QUOCGIA QUOCGIA { get; set; }
    }
}
