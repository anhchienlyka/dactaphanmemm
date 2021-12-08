using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlybanhang.Class
{
    class SqlHelper
    {
        public static int loainguoidung;
        public static string tennguoidung;
        public static string ConnectString = @"Data Source=DESKTOP-2KS3CPM\SQLEXPRESS;Initial Catalog=quanlybanh;Integrated Security=True";
        public static SqlConnection con;
    }
}
