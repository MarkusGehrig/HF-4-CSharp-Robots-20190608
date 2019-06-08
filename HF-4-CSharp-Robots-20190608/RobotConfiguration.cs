using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_4_CSharp_Robots_20190608
{
    class RobotConfiguration
    {
        List<RobotEvent> robotEvents = new List<RobotEvent>();

        public RobotConfiguration() { 
}

        internal List<RobotEvent> RobotEvents { get => robotEvents; set => robotEvents = value; }

        public void AddRobotEvents(RobotEvent robotEvent)
        {
            robotEvents.Add(robotEvent);
        }

        public void RemoveRobotEvents(RobotEvent robotEvent)
        {
            robotEvents.Remove(robotEvent);
        }
    }
}
