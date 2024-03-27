using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class DrinkService
    {
        private DrinkDao drinkdb;

        public DrinkService()
        {
            drinkdb = new DrinkDao();
        }

        public List<Drink> GetDrinks()
        {
            List<Drink> drinks = drinkdb.GetAllDrinks();
            return drinks;
        }

        
        public List<Drink> GetDrinkSupplies()
        {
            List<Drink> drinks = drinkdb.GetDrinkSupplies();
            return drinks;
        }

        public void AddDrink(Drink drink)
        {
            drinkdb.AddDrink(drink);
        }

        public void UpdateDrink(Drink drink)
        {
            drinkdb.UpdateDrink(drink);
        }

        public void DeleteDrink(Drink drink)
        {
            
            drinkdb.DeleteDrink(drink.DrinkId);
            
        }
        public Drink GetDrinkById(int drinkId)
        {
            return drinkdb.GetDrinkById(drinkId);
        }
    }
}