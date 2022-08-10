
namespace Precentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SalesReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaleListingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NetSaleByPeriodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimefin = new System.Windows.Forms.DateTimePicker();
            this.dateTimeinicio = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            this.btn30dias = new System.Windows.Forms.Button();
            this.btnMes = new System.Windows.Forms.Button();
            this.btnult7 = new System.Windows.Forms.Button();
            this.btnhoy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaleListingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NetSaleByPeriodBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalesReportBindingSource
            // 
            this.SalesReportBindingSource.DataSource = typeof(Domain.SalesReport);
            // 
            // SaleListingBindingSource
            // 
            this.SaleListingBindingSource.DataSource = typeof(Domain.SaleListing);
            // 
            // NetSaleByPeriodBindingSource
            // 
            this.NetSaleByPeriodBindingSource.DataSource = typeof(Domain.NetSaleByPeriod);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "salesReport";
            reportDataSource1.Value = this.SalesReportBindingSource;
            reportDataSource2.Name = "salesListing";
            reportDataSource2.Value = this.SaleListingBindingSource;
            reportDataSource3.Name = "netSalesByPeriod";
            reportDataSource3.Value = this.NetSaleByPeriodBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Precentacion.Report.ReportSales.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(220, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(568, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dateTimefin);
            this.panel1.Controls.Add(this.dateTimeinicio);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btn30dias);
            this.panel1.Controls.Add(this.btnMes);
            this.panel1.Controls.Add(this.btnult7);
            this.panel1.Controls.Add(this.btnhoy);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 426);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(15, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Este Ano";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimefin
            // 
            this.dateTimefin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimefin.Location = new System.Drawing.Point(15, 276);
            this.dateTimefin.Name = "dateTimefin";
            this.dateTimefin.Size = new System.Drawing.Size(168, 20);
            this.dateTimefin.TabIndex = 7;
            // 
            // dateTimeinicio
            // 
            this.dateTimeinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeinicio.Location = new System.Drawing.Point(16, 223);
            this.dateTimeinicio.Name = "dateTimeinicio";
            this.dateTimeinicio.Size = new System.Drawing.Size(168, 20);
            this.dateTimeinicio.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(15, 327);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(168, 31);
            this.button5.TabIndex = 6;
            this.button5.Text = "generar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn30dias
            // 
            this.btn30dias.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn30dias.Location = new System.Drawing.Point(16, 129);
            this.btn30dias.Name = "btn30dias";
            this.btn30dias.Size = new System.Drawing.Size(168, 31);
            this.btn30dias.TabIndex = 5;
            this.btn30dias.Text = "Utlimos 30 Dias";
            this.btn30dias.UseVisualStyleBackColor = true;
            this.btn30dias.Click += new System.EventHandler(this.btn30dias_Click);
            // 
            // btnMes
            // 
            this.btnMes.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMes.Location = new System.Drawing.Point(16, 92);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(168, 31);
            this.btnMes.TabIndex = 4;
            this.btnMes.Text = "Este Mes";
            this.btnMes.UseVisualStyleBackColor = true;
            this.btnMes.Click += new System.EventHandler(this.btnMes_Click);
            // 
            // btnult7
            // 
            this.btnult7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnult7.Location = new System.Drawing.Point(16, 55);
            this.btnult7.Name = "btnult7";
            this.btnult7.Size = new System.Drawing.Size(168, 31);
            this.btnult7.TabIndex = 3;
            this.btnult7.Text = "Ultimos 7 dias";
            this.btnult7.UseVisualStyleBackColor = true;
            this.btnult7.Click += new System.EventHandler(this.btnult7_Click);
            // 
            // btnhoy
            // 
            this.btnhoy.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhoy.Location = new System.Drawing.Point(16, 18);
            this.btnhoy.Name = "btnhoy";
            this.btnhoy.Size = new System.Drawing.Size(168, 31);
            this.btnhoy.TabIndex = 2;
            this.btnhoy.Text = "Hoy";
            this.btnhoy.UseVisualStyleBackColor = true;
            this.btnhoy.Click += new System.EventHandler(this.btnhoy_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Generador de Informes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaleListingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NetSaleByPeriodBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SalesReportBindingSource;
        private System.Windows.Forms.BindingSource SaleListingBindingSource;
        private System.Windows.Forms.BindingSource NetSaleByPeriodBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimefin;
        private System.Windows.Forms.DateTimePicker dateTimeinicio;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn30dias;
        private System.Windows.Forms.Button btnMes;
        private System.Windows.Forms.Button btnult7;
        private System.Windows.Forms.Button btnhoy;
    }
}

