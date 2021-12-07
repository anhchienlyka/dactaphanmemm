using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QL_BanHangThuanAn
{
    class SqlHelper
    {
        public static int loainguoidung;
        public static string tennguoidung;
        public static string ConnectString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + Application.StartupPath + @"\Quanlybanhang.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        public static SqlConnection con;
    }
}
