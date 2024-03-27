using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class RevenueReportDao : BaseDao
    {
        public List<Drink> GetDrinksSoldByDate(DateTime startDate, DateTime endDate)
        {
            string query = "SELECT * FROM drink WHERE last_sold_date BETWEEN @startDate AND @endDate";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@startDate", startDate),
                new SqlParameter("@endDate", endDate)
            };

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            return ReadDrinks(dataTable);
        }

        private List<Drink> ReadDrinks(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Drink drink = new Drink()
                {
                    DrinkId = (int)dr["drink_ID"],
                    DrinkName = dr["drink_name"].ToString(),
                    IsAlcoholic = Convert.ToBoolean(dr["isAlcoholic"]),
                    Price = (float)dr["price"],
                    DrinkType = dr["drink_type"].ToString(),
                    StockAmount = dr["stock_amount"].ToString(),
                    Sold = (int)dr["sold_drinks"] // Bu satır eklendi
                };
                drinks.Add(drink);
            }
            return drinks;
        }

    }
}
