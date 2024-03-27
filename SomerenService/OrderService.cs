using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenService
{
    internal class OrderService
    {
        private OrderDao orderdb;

        public OrderService()
        {
            orderdb = new OrderDao();
        }

         public OrderService(OrderDao orderdb)
        {
           
        }
        


    }
}
