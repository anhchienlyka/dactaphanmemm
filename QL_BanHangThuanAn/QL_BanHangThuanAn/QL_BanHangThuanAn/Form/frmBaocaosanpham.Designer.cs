namespace QL_BanHangThuanAn
{
    partial class frmBaocaosanpham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaocaosanpham));
            this.tblHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanlybanhangDataSet = new QL_BanHangThuanAn.QuanlybanhangDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rpvBaoCao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblHangTableAdapter = new QL_BanHangThuanAn.QuanlybanhangDataSetTableAdapters.tblHangTableAdapter();
            this.tblChitietHDBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblChitietHDBanTableAdapter = new QL_BanHangThuanAn.QuanlybanhangDataSetTableAdapters.tblChitietHDBanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanlybanhangDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblChitietHDBanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblHangBindingSource
            // 
            this.tblHangBindingSource.DataMember = "tblHang";
            this.tblHangBindingSource.DataSource = this.QuanlybanhangDataSet;
            // 
            // QuanlybanhangDataSet
            // 
            this.QuanlybanhangDataSet.DataSetName = "QuanlybanhangDataSet";
            this.QuanlybanhangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rpvBaoCao);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(907, 733);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiển thị báo cáo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(363, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "THỐNG KÊ HÀNG HÓA ";
            // 
            // rpvBaoCao
            // 
            reportDataSource1.Name = "tblHang";
            reportDataSource1.Value = this.tblHangBindingSource;
            this.rpvBaoCao.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvBaoCao.LocalReport.ReportEmbeddedResource = "QL_BanHangThuanAn.rptSanPham.rdlc";
            this.rpvBaoCao.Location = new System.Drawing.Point(12, 74);
            this.rpvBaoCao.Name = "rpvBaoCao";
            this.rpvBaoCao.Size = new System.Drawing.Size(883, 647);
            this.rpvBaoCao.TabIndex = 0;
            // 
            // tblHangTableAdapter
            // 
            this.tblHangTableAdapter.ClearBeforeFill = true;
            // 
            // tblChitietHDBanBindingSource
            // 
            this.tblChitietHDBanBindingSource.DataMember = "tblChitietHDBan";
            this.tblChitietHDBanBindingSource.DataSource = this.QuanlybanhangDataSet;
            // 
            // tblChitietHDBanTableAdapter
            // 
            this.tblChitietHDBanTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaocaosanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 733);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBaocaosanpham";
            this.Text = "Báo cáo sản phẩm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBaocaosanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanlybanhangDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblChitietHDBanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource tblHangBindingSource;
        private QuanlybanhangDataSet QuanlybanhangDataSet;
        private QuanlybanhangDataSetTableAdapters.tblHangTableAdapter tblHangTableAdapter;
        private System.Windows.Forms.BindingSource tblChitietHDBanBindingSource;
        private QuanlybanhangDataSetTableAdapters.tblChitietHDBanTableAdapter tblChitietHDBanTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rpvBaoCao;
        private System.Windows.Forms.Label label1;

    }
}