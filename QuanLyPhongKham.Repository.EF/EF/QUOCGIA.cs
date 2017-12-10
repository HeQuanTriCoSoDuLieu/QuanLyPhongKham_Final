namespace QuanLyPhongKham.Repository.EF.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QUOCGIA")]
    public partial class QUOCGIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QUOCGIA()
        {
            HANGSANXUATs = new HashSet<HANGSANXUAT>();
            NHACUNGCAPs = new HashSet<NHACUNGCAP>();
        }

        [Key]
        public int MAQUOCGIA { get; set; }

        [StringLength(50)]
        public string TENQUOCGIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HANGSANXUAT> HANGSANXUATs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHACUNGCAP> NHACUNGCAPs { get; set; }
    }
}
