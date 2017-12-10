namespace QuanLyPhongKham.Repository.EF.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETDONTHUOC")]
    public partial class CHITIETDONTHUOC
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MADONTHUOC { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MATHUOC { get; set; }

        public int? SOLUONG { get; set; }

        [Column(TypeName = "text")]
        public string HUONGDAN { get; set; }

        public virtual DONTHUOC DONTHUOC { get; set; }

        public virtual THUOC THUOC { get; set; }
    }
}
