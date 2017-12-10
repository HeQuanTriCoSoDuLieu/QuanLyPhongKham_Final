using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.DTO
{
    public class Vattuyte_DVT
    {
        public int MAVTYT { get; set; }
        public String TENVTYT { get; set; }
        public String TENDONVITINH { get; set; }
        public int SOLUONGTON { get; set; }

        public Vattuyte_DVT() { }
        public Vattuyte_DVT(int Mavattuyte, String Tenvattuyte, String Tendonvitinh,int Soluongton)
        {
            MAVTYT = Mavattuyte;
            TENVTYT = Tenvattuyte;
            TENDONVITINH = Tendonvitinh;
            SOLUONGTON = Soluongton;
        }
        public Vattuyte_DVT(DataRow Row)
        {
            MAVTYT = (int)Row["MAVTYT"];
            TENVTYT = Row["TENVATTU"].ToString();
            TENDONVITINH = Row["TENDVT"].ToString();
            SOLUONGTON = (int)Row["SOLUONGTON"];
        }
    }
}
