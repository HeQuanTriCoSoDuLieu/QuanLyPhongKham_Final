using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.DTO
{
    public class VatTuYTe
    {
        public int MAVTYT { get; set; }
        public string TENVTYT { get; set; }
        public int MADVT { get; set; }
        public int SOLUONGTON { get; set; }

        public VatTuYTe() { }

        public VatTuYTe(int mAVATTUYTE, string tENVTYT, int mADVT, int sOLUONGTON)
        {
            MAVTYT = mAVATTUYTE;
            TENVTYT = tENVTYT;
            MADVT = mADVT;
            SOLUONGTON = sOLUONGTON;
        }
        public VatTuYTe(DataRow row)
        {
            MAVTYT = (int)row["MAVTYT"];
            TENVTYT = row["TENVTYT"].ToString();
            MADVT = (int)row["MADVT"];
            SOLUONGTON = (int)row["SOLUONGTON"]; 
        }

        
    }
}
