namespace QuanLyPhongKham.Repository.EF.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETNHAPVATTU")]
    public partial class CHITIETNHAPVATTU
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MAPHIEUNHAP { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MAVTYT { get; set; }

        public int? SOLUONG { get; set; }

        public int? MAHSX { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYSX { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYHETHAN { get; set; }

        [Column(TypeName = "money")]
        public decimal? GIANHAP { get; set; }

        public int? MANHACC { get; set; }

        public virtual HANGSANXUAT HANGSANXUAT { get; set; }

        public virtual NHACUNGCAP NHACUNGCAP { get; set; }

        public virtual PHIEUNHAP PHIEUNHAP { get; set; }

        public virtual VATTUYTE VATTUYTE { get; set; }
    }
}
