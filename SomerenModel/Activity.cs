using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Activity
    {
        public int ActivityId { get; set; }
        public string Name { get; set; }
        public string Day { get; set; }
        public TimeSpan StartDayTime { get; set; }
        public TimeSpan EndDayTime { get;set; }


    }
}
