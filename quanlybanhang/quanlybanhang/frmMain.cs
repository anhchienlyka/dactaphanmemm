using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlybanhang
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect(); //Mở kết nối
        }

        private void mnuChatLieu_Click(object sender, EventArgs e)
        {
            frmDMChatLieu frmChatLieu = new frmDMChatLieu(); //Khởi tạo đối tượng
            frmChatLieu.ShowDialog(); //Hiển thị
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmDMNhanvien frmDMNhanvien = new frmDMNhanvien();
            frmDMNhanvien.ShowDialog();
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            frmDMHanghoa frmDMHanghoa = new frmDMHanghoa();
            frmDMHanghoa.ShowDialog();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmDMKhachHang frmDMKhachHang = new frmDMKhachHang();
            frmDMKhachHang.ShowDialog();
        }

        private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            frmHoadonbanhang frmHoadonbanhang = new frmHoadonbanhang();
            frmHoadonbanhang.ShowDialog();
        }
    }
}
