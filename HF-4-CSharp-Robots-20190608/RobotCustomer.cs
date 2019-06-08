using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HF_4_CSharp_Robots_20190608;

namespace HF_4_CSharp_Robots_20190608
{
    class RobotCustomer
    {
        RobotConfiguration configuration = null;

        internal RobotConfiguration Configuration { get => configuration; set => configuration = value; }

        public RobotCustomer(RobotConfiguration configuration)
        {
            this.Configuration = configuration;
        }
    }
}
