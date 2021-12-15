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
    public partial class frmNhaCungCap : Form
    {
        DataTable tblCL;
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            txtMaNhaCungCap.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataGridView(); //Hiển thị bảng tblLoaiBanh
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaNhaCungCap, TenNhaCungCap FROM tblNhaCungCap";
            tblCL = Class.Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvNhacc.DataSource = tblCL; //Nguồn dữ liệu            
            dgvNhacc.Columns[0].HeaderText = "Mã nhà cung cấp";
            dgvNhacc.Columns[1].HeaderText = "Tên nhà cung cấp";
            dgvNhacc.Columns[0].Width = 200;
            dgvNhacc.Columns[1].Width = 500;
            dgvNhacc.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvNhacc.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiế
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNhacc_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNhaCungCap.Focus();
                return;
            }
            if (tblCL.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaNhaCungCap.Text = dgvNhacc.CurrentRow.Cells["MaNhaCungCap"].Value.ToString();
            txtTenNhaCungCap.Text = dgvNhacc.CurrentRow.Cells["TenNhaCungCap"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValue(); //Xoá trắng các textbox
            txtMaNhaCungCap.Enabled = true; //cho phép nhập mới
            txtMaNhaCungCap.Focus();
        }

        private void ResetValue()
        {
            txtMaNhaCungCap.Text = "";
            txtTenNhaCungCap.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaNhaCungCap.Text.Trim().Length == 0) //Nếu chưa nhập mã loại bánh
            {
                MessageBox.Show("Bạn phải nhập mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNhaCungCap.Focus();
                return;
            }
            if (txtTenNhaCungCap.Text.Trim().Length == 0) //Nếu chưa nhập tên loại bánh
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNhaCungCap.Focus();
                return;
            }
            sql = "Select MaNhaCungCap From tblNhaCungCap where MaNhaCungCap=N'" + txtMaNhaCungCap.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã loại bánh này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhaCungCap.Focus();
                return;
            }

            sql = "INSERT INTO tblNhaCungCap VALUES(N'" +
                txtMaNhaCungCap.Text + "',N'" + txtTenNhaCungCap.Text + "')";
            Class.Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaNhaCungCap.Enabled = false;
        }
    }
}
