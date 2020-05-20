using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareSysteem_robots
{
    class CustumRobotException : Exception
    {
        public CustumRobotException()
        {

        }
        public CustumRobotException(string message) : base("Opgelet: " + message)
        {
            
        }
        public CustumRobotException(string message, Exception inner) : base("Opgelet: " + message, inner)
        {
            
        }
    }
}
