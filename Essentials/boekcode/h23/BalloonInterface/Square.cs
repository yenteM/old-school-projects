using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace BalloonInterface
{
    public class Square : IDisplayable
    {
        private int x, y;
        private int size;
        private Rectangle rect;

        public void DisplayOn(Canvas drawArea)
        {
            drawArea.Children.Add(rect);
        }

        // other methods and properties
    }
}
