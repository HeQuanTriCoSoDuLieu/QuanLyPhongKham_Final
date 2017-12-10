namespace QuanLyPhongKham.Repository.EF.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BENHNHAN")]
    public partial class BENHNHAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BENHNHAN()
        {
            PHIEUKHAMs = new HashSet<PHIEUKHAM>();
        }

        [Key]
        public int MABN { get; set; }

        [StringLength(50)]
        public string HOTEN { get; set; }

        public bool? GIOITINH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYSINH { get; set; }

        [StringLength(50)]
        public string DANTOC { get; set; }

        [StringLength(20)]
        public string SOCMND { get; set; }

        [StringLength(250)]
        public string DIACHI { get; set; }

        [StringLength(20)]
        public string SODT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUKHAM> PHIEUKHAMs { get; set; }
    }
}
