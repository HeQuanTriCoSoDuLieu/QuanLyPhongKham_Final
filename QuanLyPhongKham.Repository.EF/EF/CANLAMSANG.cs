namespace QuanLyPhongKham.Repository.EF.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CANLAMSANG")]
    public partial class CANLAMSANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CANLAMSANG()
        {
            CHITIETCLS = new HashSet<CHITIETCL>();
        }

        [Key]
        public int MACLS { get; set; }

        [StringLength(250)]
        public string TENCLS { get; set; }

        [Column(TypeName = "money")]
        public decimal? GIATIEN { get; set; }

        public int? MALOAICLS { get; set; }

        public virtual LOAICANLAMSANG LOAICANLAMSANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETCL> CHITIETCLS { get; set; }
    }
}
