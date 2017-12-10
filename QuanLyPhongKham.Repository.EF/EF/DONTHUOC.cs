namespace QuanLyPhongKham.Repository.EF.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DONTHUOC")]
    public partial class DONTHUOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DONTHUOC()
        {
            CHITIETDONTHUOCs = new HashSet<CHITIETDONTHUOC>();
        }

        [Key]
        public int MADONTHUOC { get; set; }

        public int MAPHIEUKHAM { get; set; }

        [Column(TypeName = "money")]
        public decimal? TONGCONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDONTHUOC> CHITIETDONTHUOCs { get; set; }

        public virtual PHIEUKHAM PHIEUKHAM { get; set; }
    }
}
