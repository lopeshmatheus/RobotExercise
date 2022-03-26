using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RobotExercise
{
    public class BasicRobot:Robot
    {
        public BasicRobot(string name, int fabricationDate, string color, string size) : base(name, fabricationDate, color, size)
        {
            Color = color;
            FabricationDate = fabricationDate;
            Name = name;
            Size = size;
        }
    }


}
