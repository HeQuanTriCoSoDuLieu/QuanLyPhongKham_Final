using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuanLyPhongKham.Model.DTO
{
    public class TaiKhoan
    {

        /// <summary>
        /// làm thêm cái này 
        /// </summary>
        public TaiKhoan() { }

        /// <summary>
        /// làm thêm cái này 
        /// </summary>
        public TaiKhoan(int mATK, string tENDANGNHAP, string mATKHAU, string tENHIENTHI, int mAPHANQUYEN, bool tRANGTHAI)
        {
            MATK = mATK;
            TENDANGNHAP = tENDANGNHAP;
            MATKHAU = mATKHAU;
            TENHIENTHI = tENHIENTHI;
            MAPHANQUYEN = mAPHANQUYEN;
            TRANGTHAI = tRANGTHAI;
        }


        /// <summary>
        /// dùng cho query data từ database
        /// </summary>
        /// <param name="row"></param>
        public TaiKhoan(DataRow row)
        {
            MATK = (int)row["MATK"];
            TENDANGNHAP = row["TENDANGNHAP"].ToString();
            MATKHAU = row["MATKHAU"].ToString();
            TENHIENTHI = row["TENHIENTHI"].ToString();
            MAPHANQUYEN = (int)row["MAPHANQUYEN"];
            TRANGTHAI = (bool)row["TRANGTHAI"];
        }

        public int MATK { get; set; }
        public string TENDANGNHAP { get; set; }
        public string MATKHAU { get; set; }
        public string TENHIENTHI { get; set; }
        public int MAPHANQUYEN { get; set; }
        public bool TRANGTHAI { get; set; }

    }
}
