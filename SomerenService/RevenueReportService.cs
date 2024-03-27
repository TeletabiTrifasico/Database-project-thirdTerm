using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class RevenueReportService
    {
        private RevenueReportDao drinkdb;

        public RevenueReportService()
        {
            drinkdb = new RevenueReportDao();
        }

        public RevenueReport GenerateRevenueReport(DateTime startDate, DateTime endDate)
        {
            List<Drink> drinksSold = drinkdb.GetDrinksSoldByDate(startDate, endDate);

            int totalDrinksSold = drinksSold.Sum(d => d.Sold);
            float turnover = drinksSold.Sum(d => d.Price * d.Sold);

            return new RevenueReport
            {
                TotalDrinksSold = totalDrinksSold,
                Turnover = turnover
            };
        }
    }
}
