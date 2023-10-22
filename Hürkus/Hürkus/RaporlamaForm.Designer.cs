namespace Hürkus
{
    partial class RaporlamaForm
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.havayoluDataSet = new Hürkus.havayoluDataSet();
            this.SeyehatBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SeyehatBilgileriTableAdapter = new Hürkus.havayoluDataSetTableAdapters.SeyehatBilgileriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.havayoluDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeyehatBilgileriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet";
            reportDataSource2.Value = this.SeyehatBilgileriBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hürkus.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1031, 556);
            this.reportViewer1.TabIndex = 0;
            // 
            // havayoluDataSet
            // 
            this.havayoluDataSet.DataSetName = "havayoluDataSet";
            this.havayoluDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SeyehatBilgileriBindingSource
            // 
            this.SeyehatBilgileriBindingSource.DataMember = "SeyehatBilgileri";
            this.SeyehatBilgileriBindingSource.DataSource = this.havayoluDataSet;
            // 
            // SeyehatBilgileriTableAdapter
            // 
            this.SeyehatBilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // RaporlamaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 556);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RaporlamaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RaporlamaForm";
            this.Load += new System.EventHandler(this.RaporlamaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.havayoluDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeyehatBilgileriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SeyehatBilgileriBindingSource;
        private havayoluDataSet havayoluDataSet;
        private havayoluDataSetTableAdapters.SeyehatBilgileriTableAdapter SeyehatBilgileriTableAdapter;
    }
}