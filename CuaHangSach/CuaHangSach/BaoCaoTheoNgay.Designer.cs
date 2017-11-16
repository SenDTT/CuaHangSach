namespace CuaHangSach
{
    partial class BaoCaoTheoNgay
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLBanSach = new CuaHangSach.QLBanSach();
            this.btIn = new System.Windows.Forms.Button();
            this.lbTheoNgay = new System.Windows.Forms.Label();
            this.rpvTheoNgay = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable1TableAdapter = new CuaHangSach.QLBanSachTableAdapters.DataTable1TableAdapter();
            this.dtpTheoNgay = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBanSach)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.QLBanSach;
            // 
            // QLBanSach
            // 
            this.QLBanSach.DataSetName = "QLBanSach";
            this.QLBanSach.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btIn
            // 
            this.btIn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btIn.ForeColor = System.Drawing.Color.DarkCyan;
            this.btIn.Location = new System.Drawing.Point(290, 10);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(75, 23);
            this.btIn.TabIndex = 9;
            this.btIn.Text = "In báo cáo";
            this.btIn.UseVisualStyleBackColor = false;
            this.btIn.Click += new System.EventHandler(this.btIn_Click);
            // 
            // lbTheoNgay
            // 
            this.lbTheoNgay.AutoSize = true;
            this.lbTheoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTheoNgay.Location = new System.Drawing.Point(9, 13);
            this.lbTheoNgay.Name = "lbTheoNgay";
            this.lbTheoNgay.Size = new System.Drawing.Size(72, 16);
            this.lbTheoNgay.TabIndex = 8;
            this.lbTheoNgay.Text = "Chọn ngày";
            // 
            // rpvTheoNgay
            // 
            reportDataSource2.Name = "tblSLSach";
            reportDataSource2.Value = this.DataTable1BindingSource;
            this.rpvTheoNgay.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvTheoNgay.LocalReport.ReportEmbeddedResource = "CuaHangSach.rptSLSachBanTheoNgay.rdlc";
            this.rpvTheoNgay.Location = new System.Drawing.Point(12, 40);
            this.rpvTheoNgay.Name = "rpvTheoNgay";
            this.rpvTheoNgay.Size = new System.Drawing.Size(632, 367);
            this.rpvTheoNgay.TabIndex = 10;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // dtpTheoNgay
            // 
            this.dtpTheoNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTheoNgay.Location = new System.Drawing.Point(84, 10);
            this.dtpTheoNgay.Name = "dtpTheoNgay";
            this.dtpTheoNgay.Size = new System.Drawing.Size(200, 20);
            this.dtpTheoNgay.TabIndex = 11;
            this.dtpTheoNgay.Value = new System.DateTime(2017, 11, 16, 0, 0, 0, 0);
            // 
            // BaoCaoTheoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(656, 419);
            this.Controls.Add(this.dtpTheoNgay);
            this.Controls.Add(this.rpvTheoNgay);
            this.Controls.Add(this.btIn);
            this.Controls.Add(this.lbTheoNgay);
            this.Name = "BaoCaoTheoNgay";
            this.Text = "BaoCaoTheoNgay";
            this.Load += new System.EventHandler(this.BaoCaoTheoNgay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBanSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btIn;
        private System.Windows.Forms.Label lbTheoNgay;
        private Microsoft.Reporting.WinForms.ReportViewer rpvTheoNgay;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private QLBanSach QLBanSach;
        private QLBanSachTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.DateTimePicker dtpTheoNgay;
    }
}