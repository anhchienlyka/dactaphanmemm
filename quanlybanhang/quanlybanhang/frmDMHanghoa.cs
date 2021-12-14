using quanlybanhang.Class;
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
    public partial class frmDMHanghoa : Form
    {

        DataTable tblH; //Bảng hàng
        public frmDMHanghoa()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDMHanghoa_Load(object sender, EventArgs e)
        {
            string sql1,sql2;
            sql1 = "SELECT * from tblLoaiBanh";
            sql2 = "SELECT * from tblNhaCungCap";
            txtMaHang.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataGridView();
            Functions.FillCombo(sql1, cboMaChatLieu, "MaLoaiBanh", "TenLoaiBanh");
            cboMaChatLieu.SelectedIndex = -1;
            Functions.FillCombo(sql2, cboMaNhaCungCap, "MaNhaCungCap", "TenNhaCungCap");
            cboMaNhaCungCap.SelectedIndex = -1;
            ResetValues();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from tblHang";
            tblH = Functions.GetDataToTable(sql);
            dgvHang.DataSource = tblH;
            dgvHang.Columns[0].HeaderText = "Mã hàng";
            dgvHang.Columns[1].HeaderText = "Tên hàng";
            dgvHang.Columns[2].HeaderText = "Loại bánh";
            dgvHang.Columns[3].HeaderText = "Nhà cung cấp";
            dgvHang.Columns[4].HeaderText = "Số lượng";
            dgvHang.Columns[5].HeaderText = "Đơn giá nhập";
            dgvHang.Columns[6].HeaderText = "Đơn giá bán";
            dgvHang.Columns[7].HeaderText = "Ảnh";
            dgvHang.Columns[8].HeaderText = "Ghi chú";
            dgvHang.Columns[0].Width = 80;
            dgvHang.Columns[1].Width = 140;
            dgvHang.Columns[2].Width = 80;
            dgvHang.Columns[3].Width = 80;
            dgvHang.Columns[4].Width = 80;
            dgvHang.Columns[5].Width = 100;
            dgvHang.Columns[6].Width = 100;
            dgvHang.Columns[7].Width = 200;
            dgvHang.Columns[8].Width = 300;
            dgvHang.AllowUserToAddRows = false;
            dgvHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvHang_Click(object sender, EventArgs e)
        {
            string MaChatLieu;
            string MaNhaCungCap;
            string sql;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang.Focus();
                return;
            }
            if (tblH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaHang.Text = dgvHang.CurrentRow.Cells["MaHang"].Value.ToString();
            txtTenHang.Text = dgvHang.CurrentRow.Cells["TenHang"].Value.ToString();
            MaChatLieu = dgvHang.CurrentRow.Cells["MaLoaiBanh"].Value.ToString();
            sql = "SELECT TenLoaiBanh FROM tblLoaiBanh WHERE MaLoaiBanh=N'" + MaChatLieu + "'";
            cboMaChatLieu.Text = Functions.GetFieldValues(sql);

            MaNhaCungCap = dgvHang.CurrentRow.Cells["MaNhaCungCap"].Value.ToString();
            sql = "SELECT TenNhaCungCap FROM tblNhaCungCap WHERE MaNhaCungCap=N'" + MaNhaCungCap + "'";
            cboMaNhaCungCap.Text = Functions.GetFieldValues(sql);


            txtSoLuong.Text = dgvHang.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtDonGiaNhap.Text = dgvHang.CurrentRow.Cells["DonGiaNhap"].Value.ToString();
            txtDonGiaBan.Text = dgvHang.CurrentRow.Cells["DonGiaBan"].Value.ToString();
            sql = "SELECT Anh FROM tblHang WHERE MaHang=N'" + txtMaHang.Text + "'";
            txtAnh.Text = Functions.GetFieldValues(sql);
            picAnh.Image = Image.FromFile(txtAnh.Text);
            sql = "SELECT Ghichu FROM tblHang WHERE MaHang = N'" + txtMaHang.Text + "'";
            txtGhichu.Text = Functions.GetFieldValues(sql);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void ResetValues()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            cboMaChatLieu.Text = "";
            txtSoLuong.Text = "0";
            txtDonGiaNhap.Text = "0";
            txtDonGiaBan.Text = "0";
            txtSoLuong.Enabled = true;
            txtDonGiaNhap.Enabled = false;
            txtDonGiaBan.Enabled = false;
            txtAnh.Text = "";
            picAnh.Image = null;
            txtGhichu.Text = "";
        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaHang.Enabled = true;
            txtMaHang.Focus();
            txtSoLuong.Enabled = true;
            txtDonGiaNhap.Enabled = true;
            txtDonGiaBan.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang.Focus();
                return;
            }
            if (txtTenHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHang.Focus();
                return;
            }
            if (cboMaChatLieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaChatLieu.Focus();
                return;
            }
            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh hoạ cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnOpen.Focus();
                return;
            }
            sql = "SELECT MaHang FROM tblHang WHERE MaHang=N'" + txtMaHang.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã tồn tại, bạn phải chọn mã hàng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang.Focus();
                return;
            }
            sql = "INSERT INTO tblHang(MaHang,TenHang,MaLoaiBanh,MaNhaCungCap,SoLuong,DonGiaNhap, DonGiaBan,Anh,Ghichu) VALUES(N'"
                + txtMaHang.Text.Trim() + "',N'" + txtTenHang.Text.Trim() +
                "',N'" + cboMaChatLieu.SelectedValue.ToString() + "',N'" + cboMaNhaCungCap.SelectedValue.ToString()+
                "'," + txtSoLuong.Text.Trim() + "," + txtDonGiaNhap.Text +
                "," + txtDonGiaBan.Text + ",'" + txtAnh.Text + "',N'" + txtGhichu.Text.Trim() + "')";

            Functions.RunSQL(sql);
            LoadDataGridView();
            //ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaHang.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang.Focus();
                return;
            }
            if (txtTenHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHang.Focus();
                return;
            }
            if (cboMaChatLieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaChatLieu.Focus();
                return;
            }
            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải ảnh minh hoạ cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAnh.Focus();
                return;
            }
            sql = "UPDATE tblHang SET TenHang=N'" + txtTenHang.Text.Trim().ToString() +
                "',MaLoaiBanh=N'" + cboMaChatLieu.SelectedValue.ToString() +
                 "',MaNhaCungCap=N'" + cboMaNhaCungCap.SelectedValue.ToString() +
                "',SoLuong=" + txtSoLuong.Text +
                ",Anh='" + txtAnh.Text + "',Ghichu=N'" + txtGhichu.Text + "' WHERE MaHang=N'" + txtMaHang.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblHang WHERE MaHang=N'" + txtMaHang.Text + "'";
                Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaHang.Enabled = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMaHang.Text == "") && (txtTenHang.Text == "") && (cboMaChatLieu.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from tblHang WHERE 1=1";
            if (txtMaHang.Text != "")
                sql += " AND MaHang LIKE N'%" + txtMaHang.Text + "%'";
            if (txtTenHang.Text != "")
                sql += " AND TenHang LIKE N'%" + txtTenHang.Text + "%'";
            if (cboMaChatLieu.Text != "")
                sql += " AND MaLoaiBanh LIKE N'%" + cboMaChatLieu.SelectedValue + "%'";
            tblH = Functions.GetDataToTable(sql);
            if (tblH.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + tblH.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvHang.DataSource = tblH;
            ResetValues();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT MaHang,TenHang,MaLoaiBanh,MaNhaCungCap,SoLuong,DonGiaNhap,DonGiaBan,Anh,Ghichu FROM tblHang";
            tblH = Functions.GetDataToTable(sql);
            dgvHang.DataSource = tblH;
        }
    }
}
