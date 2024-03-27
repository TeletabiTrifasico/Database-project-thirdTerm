using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Drink
    {

        public int DrinkId { get; set; } //database Id
        public string DrinkName { get; set; }
        public bool IsAlcoholic { get; set; }
        public float Price { get; set; }
        public string DrinkType { get; set; }

        public string StockAmount { get; set; }

        public int Sold { get; set; }


    }
}
