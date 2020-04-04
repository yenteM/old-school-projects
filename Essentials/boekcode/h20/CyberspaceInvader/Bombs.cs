using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberspaceInvader
{
    public class Bombs
    {
        private List<Bomb> bombList = new List<Bomb>();

        public void Add(Bomb bomb)
        {
            bombList.Add(bomb);
        }

        public void Remove(Bomb bomb)
        {
            bombList.Remove(bomb);
        }

        public void Move()
        {
            for (int i = 0; i < bombList.Count; i++)
            {
                bombList[i].Move();
            }
        }

        public void CheckHit(User user)
        {
            for (int i = 0; i < bombList.Count; i++)
            {
                bombList[i].CheckHit(user);
            }
        }
    }
}
