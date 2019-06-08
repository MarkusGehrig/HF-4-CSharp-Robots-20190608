using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_4_CSharp_Robots_20190608
{
    class Program
    {
        static void Main(string[] args)
        {
            RobotConfiguration robotConfiguration = new RobotConfiguration();
            RobotCustomer robotCustomer = new RobotCustomer(robotConfiguration);

            robotConfiguration.AddRobotEvents(new RobotEvent("Alert", new DateTime(), "High"));
            robotConfiguration.AddRobotEvents(new RobotEvent("Warning", new DateTime(), "Medium"));

            foreach (var robotEvent in robotConfiguration.RobotEvents)
            {
                Console.WriteLine(robotEvent.Date + " " + robotEvent.Priority + " " + robotEvent.Type);
            }
            
            Console.ReadKey();
        }
    }
}
