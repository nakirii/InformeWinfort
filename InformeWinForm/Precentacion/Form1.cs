using System;
using System.Windows.Forms;
using Domain;

namespace Precentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void getSaleReport(DateTime startDate, DateTime endDate)
        {
            SalesReport salesReport = new SalesReport();
            salesReport.createSalesOrderReport(startDate, endDate);
            SalesReportBindingSource.DataSource = salesReport;
            SaleListingBindingSource.DataSource = salesReport.saleListing;
            NetSaleByPeriodBindingSource.DataSource = salesReport.netSaleByPeriod;

            this.reportViewer1.RefreshReport();

        }

        private void btnhoy_Click_1(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today;
            var todate = DateTime.Now;
            getSaleReport(fromDate, todate);
        }

        private void btnult7_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today.AddDays(-7);
            var todate = DateTime.Now;
            getSaleReport(fromDate, todate);
        }

        private void btnMes_Click(object sender, EventArgs e)
        {
            var fromDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var todate = DateTime.Now;
            getSaleReport(fromDate, todate);
        }

        private void btn30dias_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today.AddDays(-30);
            var todate = DateTime.Now;
            getSaleReport(fromDate, todate);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fromDate = new DateTime(DateTime.Now.Year, 1, 1);
            var todate = DateTime.Now;
            getSaleReport(fromDate, todate);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var fromDate = dateTimeinicio.Value;
            var todate = dateTimefin.Value;
            getSaleReport(fromDate, new DateTime(todate.Year, todate.Month, todate.Day, 23, 59, 59));
        }
    }
}
