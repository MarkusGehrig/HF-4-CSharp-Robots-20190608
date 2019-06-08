using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_4_CSharp_Robots_20190608
{
    class RobotEvent
    {
        string type = "";
        DateTime date = new DateTime();
        string priority = "";

        public RobotEvent(string type = "", DateTime date = new DateTime(), string priority = "")
        {
            Priority = priority;
            Date = date;
            Type = type;
        }

        public string Type { get => type; set => type = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Priority { get => priority; set => priority = value; }
    }
}
