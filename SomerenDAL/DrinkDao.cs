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
            string query = "SELECT drink_ID, drink_name, isAlcoholic, price,drink_type,stock_amount,sold_drinks  FROM [drink]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        // sql query to get drinksupplies and sold
        public List<Drink> GetDrinkSupplies()
        {
            string query = "SELECT drink_ID, drink_name, isAlcoholic, price, drink_type, stock_amount,sold_drinks FROM [drink]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Drink> drinks = ReadTables(ExecuteSelectQuery(query, sqlParameters));
            return drinks.OrderBy(d => d.DrinkName).ToList();//to sort by name
        }
        public Drink GetDrinkById(int drinkId)
        {
            string query = "SELECT drink_ID, drink_name, isAlcoholic, price, drink_type, stock_amount,sold_drinks FROM [drink] WHERE drink_ID = @DrinkId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DrinkId", drinkId);
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            List<Drink> drinks = ReadTables(dataTable);
            return drinks.FirstOrDefault(); 
        }


        //sql query to add drinks to the database !!! ASK 
        public void AddDrink(Drink drink)
        {
            string query = "INSERT INTO [drink] (drink_name, isAlcoholic, price, drink_type, stock_amount,sold_drinks) VALUES (@Name, @IsAlcoholic, @Price, @Type, @StockAmount,@SoldDrinks)";
            SqlParameter[] sqlParameters = new SqlParameter[6]; 
            sqlParameters[0] = new SqlParameter("@Name", drink.DrinkName);
            sqlParameters[1] = new SqlParameter("@IsAlcoholic", drink.IsAlcoholic);
            sqlParameters[2] = new SqlParameter("@Price", drink.Price);
            sqlParameters[3] = new SqlParameter("@Type", drink.DrinkType);
            sqlParameters[4] = new SqlParameter("@StockAmount", drink.StockAmount);
            sqlParameters[5] = new SqlParameter("@SoldDrinks", drink.Sold);
            ExecuteEditQuery(query, sqlParameters);
        }


        //sql query to update drinks to the database
        public void UpdateDrink(Drink drink) 
        {
            string query = "UPDATE [drink] SET drink_name = @Name, isAlcoholic = @IsAlcoholic, price = @Price, drink_type = @Type, stock_amount = @StockAmount, sold_drinks= @SoldDrinks  WHERE drink_ID = @DrinkId";
            SqlParameter[] sqlParameters = new SqlParameter[7];
            sqlParameters[0] = new SqlParameter("@Name", drink.DrinkName);
            sqlParameters[1] = new SqlParameter("@DrinkId", drink.DrinkId);
            sqlParameters[2] = new SqlParameter("@IsAlcoholic", drink.IsAlcoholic);
            sqlParameters[3] = new SqlParameter("@Price", drink.Price);
            sqlParameters[4] = new SqlParameter("@Type", drink.DrinkType);
            sqlParameters[5] = new SqlParameter("@SoldDrinks", drink.Sold);
            sqlParameters[6] = new SqlParameter("@StockAmount", drink.StockAmount);
            ExecuteEditQuery(query, sqlParameters);
        }
        
        //sql query to delete drinks from database
        public void DeleteDrink(int drinkId)
        {
            string query = "DELETE FROM [drink] WHERE drink_ID = @DrinkId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DrinkId", drinkId);
            ExecuteEditQuery(query, sqlParameters);
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
                    StockAmount = dr["stock_amount"].ToString(),
                    Sold=(int)dr["sold_drinks"]
                };
                drinks.Add(drink);
            }
            return drinks;
        }

    }
}
