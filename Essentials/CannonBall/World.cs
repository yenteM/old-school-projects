using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CannonBall
{
    class World
    {
        private double yPos, distance, height;


        public double ConvertyPos(double yPos)
        {
            this.yPos = height - yPos - 5;
            return this.yPos;
        }

        public double Distance
        {
            get { return distance; }
            set { distance = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

    }
}
