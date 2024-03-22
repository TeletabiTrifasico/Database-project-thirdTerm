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
    public class ActivityDao : BaseDao
    {
        public List<Activity> GetAllActivities()
        {
            string query = "SELECT activityId, name, day, start_day_time, end_day_time  FROM [activity]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> activities = new List<Activity>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Activity activity = new Activity()
                {
                    ActivityId = (int)dr["activityID"],
                    Name = dr["name"].ToString(),
                    Day = dr["day"].ToString(),
                    StartDayTime = (TimeSpan)dr["start_day_time"],
                    EndDayTime = (TimeSpan)dr["end_day_time"]
                };
                activities.Add(activity);
            }
            return activities;
        }
    }
}
