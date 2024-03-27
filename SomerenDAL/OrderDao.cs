using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class OrderDao:BaseDao
    {

        //query to add orders to sql database!!
        public void AddOrder(Order order)
        {
            string query = "INSERT INTO [orders] (quantity,student_number, drink_ID) VALUES ('@quantity','@student_number' ,'@drink_ID')";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@quantity", order.quantity);
            sqlParameters[1] = new SqlParameter("@student_number",order.StudentNumber);
            sqlParameters[2] = new SqlParameter("@drink_ID",order.drinkId);

            ExecuteEditQuery(query, sqlParameters);

        }
    }
}
