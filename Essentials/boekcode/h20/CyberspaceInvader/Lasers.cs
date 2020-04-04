using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberspaceInvader
{
    public class Lasers
    {
        private List<Laser> laserList = new List<Laser>();

        public void Add(Laser laser)
        {
            laserList.Add(laser);
        }

        public void Remove(Laser laser)
        {
            laserList.Remove(laser);
        }

        public void Move()
        {
            for (int i = 0; i < laserList.Count; i++)
            {
                laserList[i].Move();
            }
        }

        public void CheckHit(Alien alien)
        {
            for (int i = 0; i < laserList.Count; i++)
            {
                laserList[i].CheckHit(alien);
            }
        }
    }
}
