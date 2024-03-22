using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class RoomDao : BaseDao
    {
        
            public List<Room> GetAllRooms()
            {
                string query = "SELECT * FROM room";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                return ReadTables(ExecuteSelectQuery(query, sqlParameters));
            }

            private List<Room> ReadTables(DataTable dataTable)
            {
                List<Room> rooms = new List<Room>();

                foreach (DataRow dr in dataTable.Rows)
                {
                    Room room = new Room()
                    {
                        Id = (int)dr["roomID"],
                        Number = (int)dr["floornumber"],
                        Size = (int)dr["capacity"],
                        Type = (string)dr["building"]
                    };
                    rooms.Add(room);
                }
                return rooms;
            }
    }

}

