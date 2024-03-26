using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class LecturerDao : BaseDao
    {
        public List<Lecturer> GetAllLecturers()
        {
            string query = "SELECT * FROM lecturer";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Lecturer> ReadTables(DataTable dataTable)
        {
            List<Lecturer> lecturers = new List<Lecturer>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Lecturer lecturer = new Lecturer()
                {
                    LecturerId = (int)dr["lecturer_ID"],
                    FirstName = dr["first_name"].ToString(),
                    LastName = dr["last_name"].ToString(),
                    Age = (int)dr["age"],
                    PhoneNumber = (int)dr["phone_number"],
                    RoomId = (int)dr["roomID"],
                };
                lecturers.Add(lecturer);
            }
            return lecturers;
        }

    }
}
