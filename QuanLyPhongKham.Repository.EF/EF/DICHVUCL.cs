namespace QuanLyPhongKham.Repository.EF.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DICHVUCLS")]
    public partial class DICHVUCL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DICHVUCL()
        {
            CHITIETCLS = new HashSet<CHITIETCL>();
        }

        [Key]
        public int MADICHVUCLS { get; set; }

        public int? MAPHIEUKHAM { get; set; }

        [Column(TypeName = "money")]
        public decimal? TONGCONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETCL> CHITIETCLS { get; set; }

        public virtual PHIEUKHAM PHIEUKHAM { get; set; }
    }
}
