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
    public class DrinkDao : BaseDao
    {
        public List<Drink> GetAllDrinks()
        {
            string query = "SELECT drink_ID, drink_name, isAlcoholic, price,drink_type,stock_amount  FROM [drink]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }


    
        private List<Drink> ReadTables(DataTable dataTable)
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
                    StockAmount = dr["stock_amount"].ToString()
                };
                drinks.Add(drink);
            }
            return drinks;
        }
    }
}
