
namespace CAFE_SHOP_MANAGEMENT
{
    partial class frmReport
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DoanhThu = new CAFE_SHOP_MANAGEMENT.DoanhThu();
            this.DoanhThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DoanhThuTableAdapter = new CAFE_SHOP_MANAGEMENT.DoanhThuTableAdapters.DoanhThuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoanhThuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DoanhThu";
            reportDataSource1.Value = this.DoanhThuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CAFE_SHOP_MANAGEMENT.DoanhThu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1225, 567);
            this.reportViewer1.TabIndex = 0;
            // 
            // DoanhThu
            // 
            this.DoanhThu.DataSetName = "DoanhThu";
            this.DoanhThu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DoanhThuBindingSource
            // 
            this.DoanhThuBindingSource.DataMember = "DoanhThu";
            this.DoanhThuBindingSource.DataSource = this.DoanhThu;
            // 
            // DoanhThuTableAdapter
            // 
            this.DoanhThuTableAdapter.ClearBeforeFill = true;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1249, 591);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoanhThuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DoanhThuBindingSource;
        private DoanhThu DoanhThu;
        private DoanhThuTableAdapters.DoanhThuTableAdapter DoanhThuTableAdapter;
    }
}