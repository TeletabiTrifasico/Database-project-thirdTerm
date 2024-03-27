using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using SomerenModel;

namespace SomerenDAL
{
    public class StudentDao : BaseDao
    {
        public List<Student> GetAllStudents()
        {
            string query = "SELECT student_number, first_name, last_name, class, phone_number, nationality, roomID FROM [student]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    Number = (int)dr["student_number"],
                    FirstName = dr["first_name"].ToString(),
                    LastName = dr["last_name"].ToString(),
                    Class = (int)dr["class"],
                    PhoneNumber = (int)dr["phone_number"],
                    Nationality = dr["nationality"].ToString()

                };
                students.Add(student);
            }
            return students;
        }
    }
}