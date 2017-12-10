namespace QuanLyPhongKham.Repository.EF.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETCLS")]
    public partial class CHITIETCL
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MADICHVUCLS { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MACLS { get; set; }

        [StringLength(250)]
        public string KETQUA { get; set; }

        public virtual CANLAMSANG CANLAMSANG { get; set; }

        public virtual DICHVUCL DICHVUCL { get; set; }
    }
}
