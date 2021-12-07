using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QL_BanHangThuanAn
{
    public partial class frmTKKinhdoanh : Form
    {
        public frmTKKinhdoanh()
        {
            InitializeComponent();
        }

        private void frmTKKinhdoanh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlybanhangDataSet1.VW_Thongkekinhdoanh' table. You can move, or remove it, as needed.
            this.VW_ThongkekinhdoanhTableAdapter.Fill(this.quanlybanhangDataSet1.VW_Thongkekinhdoanh);
            // TODO: This line of code loads data into the 'QuanlybanhangDataSet.VW_Thongkekinhdoanh' table. You can move, or remove it, as needed.
            this.VW_ThongkekinhdoanhTableAdapter.Fill(this.QuanlybanhangDataSet.VW_Thongkekinhdoanh);

            this.reportViewer1.RefreshReport();
        }
    }
}
