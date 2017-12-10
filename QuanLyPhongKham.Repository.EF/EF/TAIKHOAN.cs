namespace QuanLyPhongKham.Repository.EF.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAIKHOAN")]
    public partial class TAIKHOAN
    {
        [Key]
        public int MATK { get; set; }

        [Required]
        [StringLength(50)]
        public string TENDANGNHAP { get; set; }

        [Required]
        [StringLength(50)]
        public string MATKHAU { get; set; }

        [StringLength(50)]
        public string TENHIENTHI { get; set; }

        public int? MAPHANQUYEN { get; set; }

        public bool? TRANGTHAI { get; set; }

        public virtual PHANQUYEN PHANQUYEN { get; set; }
    }
}
