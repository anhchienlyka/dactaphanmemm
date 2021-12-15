using quanlybanhang.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlybanhang
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
        }
        string cs = @"Data Source=DESKTOP-2KS3CPM\SQLEXPRESS;Initial Catalog=quanlybanh;Integrated Security=True";
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtTendangnhap.Text == "" || txtMatkhau.Text == "")
            {
                MessageBox.Show("Không được để trống tên đăng nhập hoặc mật khẩu");
                return;
            }
            try
            {
                //Create SqlConnection
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from tblLogin where MaNhanVien=@username and Pass=@password", con);
                cmd.Parameters.AddWithValue("@username", txtTendangnhap.Text);
                cmd.Parameters.AddWithValue("@password", txtMatkhau.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    this.Hide();
                    frmMain fm = new frmMain();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
