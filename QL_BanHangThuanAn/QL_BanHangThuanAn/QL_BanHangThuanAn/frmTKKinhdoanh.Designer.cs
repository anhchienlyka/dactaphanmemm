namespace QL_BanHangThuanAn
{
    partial class frmTKKinhdoanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTKKinhdoanh));
            this.vWThongkekinhdoanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlybanhangDataSet1 = new QL_BanHangThuanAn.QuanlybanhangDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.QuanlybanhangDataSet = new QL_BanHangThuanAn.QuanlybanhangDataSet();
            this.VW_ThongkekinhdoanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VW_ThongkekinhdoanhTableAdapter = new QL_BanHangThuanAn.QuanlybanhangDataSetTableAdapters.VW_ThongkekinhdoanhTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vWThongkekinhdoanhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlybanhangDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanlybanhangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VW_ThongkekinhdoanhBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vWThongkekinhdoanhBindingSource
            // 
            this.vWThongkekinhdoanhBindingSource.DataMember = "VW_Thongkekinhdoanh";
            this.vWThongkekinhdoanhBindingSource.DataSource = this.quanlybanhangDataSet1;
            // 
            // quanlybanhangDataSet1
            // 
            this.quanlybanhangDataSet1.DataSetName = "QuanlybanhangDataSet";
            this.quanlybanhangDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vWThongkekinhdoanhBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QL_BanHangThuanAn.rptKinhdoanh.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 54);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(839, 657);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(232, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "THỐNG KÊ TÌNH HÌNH KINH DOANH";
            // 
            // QuanlybanhangDataSet
            // 
            this.QuanlybanhangDataSet.DataSetName = "QuanlybanhangDataSet";
            this.QuanlybanhangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VW_ThongkekinhdoanhBindingSource
            // 
            this.VW_ThongkekinhdoanhBindingSource.DataMember = "VW_Thongkekinhdoanh";
            this.VW_ThongkekinhdoanhBindingSource.DataSource = this.QuanlybanhangDataSet;
            // 
            // VW_ThongkekinhdoanhTableAdapter
            // 
            this.VW_ThongkekinhdoanhTableAdapter.ClearBeforeFill = true;
            // 
            // frmTKKinhdoanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 723);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTKKinhdoanh";
            this.Text = "Thống kê kinh doanh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTKKinhdoanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vWThongkekinhdoanhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlybanhangDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanlybanhangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VW_ThongkekinhdoanhBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VW_ThongkekinhdoanhBindingSource;
        private QuanlybanhangDataSet QuanlybanhangDataSet;
        private System.Windows.Forms.Label label1;
        private QuanlybanhangDataSetTableAdapters.VW_ThongkekinhdoanhTableAdapter VW_ThongkekinhdoanhTableAdapter;
        private QuanlybanhangDataSet quanlybanhangDataSet1;
        private System.Windows.Forms.BindingSource vWThongkekinhdoanhBindingSource;
    }
}