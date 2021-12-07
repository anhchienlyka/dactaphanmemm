using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using QL_BanHangThuanAn.Class; 

namespace QL_BanHangThuanAn
{
    public partial class frmBaocaosanpham : Form
    {
        public frmBaocaosanpham()
        {
            InitializeComponent();
        }

        private void frmBaocaosanpham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanlybanhangDataSet.tblChitietHDBan' table. You can move, or remove it, as needed.
            this.tblChitietHDBanTableAdapter.Fill(this.QuanlybanhangDataSet.tblChitietHDBan);
            // TODO: This line of code loads data into the 'QuanlybanhangDataSet.tblHang' table. You can move, or remove it, as needed.
            this.tblHangTableAdapter.Fill(this.QuanlybanhangDataSet.tblHang);

            this.rpvBaoCao.RefreshReport();
            this.rpvBaoCao.RefreshReport();
            this.rpvBaoCao.RefreshReport();
            this.rpvBaoCao.RefreshReport();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            //Khai báo câu lệnh SQL
            String sql = "select * from tblHang";
            SqlConnection con = new SqlConnection();
            //Truyền vào chuỗi kết nối tới cơ sở dữ liệu
            //Gọi Application.StartupPath để lấy đường dẫn tới thư mục chứa file chạy chương trình 
            con.ConnectionString = @"Data Source=DUYSONIDOL-PC\SQLEXPRESS;Initial Catalog=Quanlybanhang;Integrated Security=True";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            //Khai báo chế độ xử lý báo cáo, trong trường hợp này lấy báo cáo ở local
            rpvBaoCao.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            //Đường dẫn báo cáo
            rpvBaoCao.LocalReport.ReportPath = "rptSanPham.rdlc";
            //Nếu có dữ liệu
            if (ds.Tables[0].Rows.Count > 0)
            {
                //Tạo nguồn dữ liệu cho báo cáo
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "tblHang";
                rds.Value = ds.Tables[0];
                //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
                rpvBaoCao.LocalReport.DataSources.Clear();
                //Add dữ liệu vào báo cáo
                rpvBaoCao.LocalReport.DataSources.Add(rds);
                //Refresh lại báo cáo
                rpvBaoCao.RefreshReport();
            }
        }
    }
}
