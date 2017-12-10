namespace QuanLyPhongKham.Repository.EF.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [Key]
        public int MAHOADON { get; set; }

        public int MAPHIEUKHAM { get; set; }

        [Column(TypeName = "money")]
        public decimal? TONGCONG { get; set; }

        public virtual PHIEUKHAM PHIEUKHAM { get; set; }
    }
}
