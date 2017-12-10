namespace QuanLyPhongKham.Repository.EF.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HINHTHUCKHAM")]
    public partial class HINHTHUCKHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HINHTHUCKHAM()
        {
            PHIEUKHAMs = new HashSet<PHIEUKHAM>();
        }

        [Key]
        public int MAHINHTHUCKHAM { get; set; }

        [StringLength(100)]
        public string TENHINHTHUCKHAM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUKHAM> PHIEUKHAMs { get; set; }
    }
}
