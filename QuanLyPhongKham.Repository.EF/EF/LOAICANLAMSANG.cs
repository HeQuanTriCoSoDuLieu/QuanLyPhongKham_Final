namespace QuanLyPhongKham.Repository.EF.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAICANLAMSANG")]
    public partial class LOAICANLAMSANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAICANLAMSANG()
        {
            CANLAMSANGs = new HashSet<CANLAMSANG>();
        }

        [Key]
        public int MALOAICLS { get; set; }

        [StringLength(250)]
        public string TENLOAI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CANLAMSANG> CANLAMSANGs { get; set; }
    }
}
