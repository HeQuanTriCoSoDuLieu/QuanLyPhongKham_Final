using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace QuanLyPhongKham.Infrastructure
{
    public class LibraryParameter
    {

        public static string connectionstring
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["QuanLyPhongKhamDbContext"].ToString();
            }
        }

        public static string persistancestrategy
        {
            get
            {
                return ConfigurationManager.AppSettings["PersistanceStrategy"].ToString();
            }
        }


    }
}
