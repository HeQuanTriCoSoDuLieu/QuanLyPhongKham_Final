namespace QuanLyPhongKham.Repository.EF.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VATTUYTE")]
    public partial class VATTUYTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VATTUYTE()
        {
            CHITIETNHAPVATTUs = new HashSet<CHITIETNHAPVATTU>();
        }

        [Key]
        public int MAVTYT { get; set; }

        [StringLength(250)]
        public string TENVATTU { get; set; }

        public int? MADVT { get; set; }

        public int? SOLUONGTON { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETNHAPVATTU> CHITIETNHAPVATTUs { get; set; }

        public virtual DONVITINH DONVITINH { get; set; }
    }
}
