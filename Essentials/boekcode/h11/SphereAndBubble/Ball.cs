using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SphereAndBubble
{
    public class Ball : Sphere
    {
        public void MoveLeft(int amount)
        {
            xCoord -= amount;
            UpdateEllipse();
        }

        public void MoveRight(int amount)
        {
            xCoord += amount;
            UpdateEllipse();
        }
    }
}
