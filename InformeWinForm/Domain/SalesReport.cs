using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SalesReport
    {
        //atributes-Propieties
        public DateTime reportDate { get; private set; }
        public DateTime startDate { get; private set; }
        public DateTime endDate { get; private set; }
        public List<SaleListing> saleListing { get; private set; }
        public List<NetSaleByPeriod> netSaleByPeriod { get; private set; }
        public double totalNetSales { get; private set; }

        //methods
        public void createSalesOrderReport(DateTime fromDate, DateTime toDate)
        {
            //implements dates 
            reportDate = DateTime.Now;
            startDate = fromDate;
            endDate = toDate;

            //create sales listing
            var orderDao = new OrderDao();
            var result = orderDao.getSaleOrder(fromDate, toDate);
            saleListing = new List<SaleListing>();
            foreach (System.Data.DataRow rows in result.Rows)
            {
                var salesModel = new SaleListing() {
                    orderId = Convert.ToInt32(rows[0]),
                    orderDate = Convert.ToDateTime(rows[1]),
                    customer = Convert.ToString(rows[2]),
                    products= Convert.ToString(rows[3]),
                    totalAmount = Convert.ToDouble(rows[4])
                };
                saleListing.Add(salesModel);
                //calcular total net sales
                totalNetSales += Convert.ToDouble(rows[4]);
            }

            //cargar reporte por periodo (opcional)
            //calcular total de net sale by peiodo
            //create tem list net sales by date
            var listSaleByDate = (from sales in saleListing
                                  group sales by sales.orderDate
                                  into listSales
                                  select new { 
                                  date = listSales.Key,
                                  amont = listSales.Sum(item => item.totalAmount)
                                  }).AsEnumerable();
            //get number of day
            int totalDays = Convert.ToInt32((toDate - fromDate).Days);
            //group period by days
            if (totalDays<=7)
            {
                netSaleByPeriod = (from sales in listSaleByDate
                                    group sales by sales.date.ToString("dd-MMM-yyyy")
                                    into listSales
                                    select new NetSaleByPeriod
                                    {
                                        period = listSales.Key,
                                        netSale = listSales.Sum(item => item.amont)
                                    }).ToList();
            }
            //group period by week
            else if (totalDays<=30)
            {
                netSaleByPeriod = (from sales in listSaleByDate
                                    group sales by 
                                    System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                        sales.date,System.Globalization.CalendarWeekRule.FirstDay,DayOfWeek.Monday)
                                   into listSales
                                    select new NetSaleByPeriod
                                    {
                                        period = "Week "+listSales.Key.ToString(),
                                        netSale = listSales.Sum(item => item.amont)
                                    }).ToList();
            }
            //group period by months
            else if (totalDays <= 365)
            {
                netSaleByPeriod = (from sales in listSaleByDate
                                    group sales by sales.date.ToString("MMM-yyyy")
                                      into listSales
                                    select new NetSaleByPeriod
                                    {
                                        period = listSales.Key,
                                        netSale = listSales.Sum(item => item.amont)
                                    }).ToList();
            }
            //group period by years
            else
            {
                netSaleByPeriod = (from sales in listSaleByDate
                                    group sales by sales.date.ToString("yyyy")
                                    into listSales
                                    select new NetSaleByPeriod
                                    {
                                        period = listSales.Key,
                                        netSale = listSales.Sum(item => item.amont)
                                    }).ToList();
            }

        }
    }
}
