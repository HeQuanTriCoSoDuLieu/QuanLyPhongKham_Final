namespace QuanLyPhongKham.Repository.EF.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETPHIEUNHAPTHUOC")]
    public partial class CHITIETPHIEUNHAPTHUOC
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MAPHIEUNHAP { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MATHUOC { get; set; }

        public int? SOLUONG { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYSX { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYHETHAN { get; set; }

        [Column(TypeName = "money")]
        public decimal? GIANHAP { get; set; }

        [Column(TypeName = "money")]
        public decimal? GIABANLE { get; set; }

        public int? MAHSX { get; set; }

        public int? MANHACC { get; set; }

        public virtual HANGSANXUAT HANGSANXUAT { get; set; }

        public virtual NHACUNGCAP NHACUNGCAP { get; set; }

        public virtual PHIEUNHAP PHIEUNHAP { get; set; }

        public virtual THUOC THUOC { get; set; }
    }
}
