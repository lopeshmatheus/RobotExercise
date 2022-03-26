using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotExercise
{
    public class Robot
    {
        public string Color { get; set; }
        public int FabricationDate { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }


        public Robot(string name, int fabricationDate, string color, string size)
        {
            Color = color;
            FabricationDate = fabricationDate; 
            Name = name;
            Size = size;
        }

        public string Present()
        {
            string a = $"My name is {Name}, i was born in {FabricationDate}, My color is {Color} and im {Size}";
            return a;
        }
    }
}
