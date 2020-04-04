using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Shapes
{
    public abstract class Shape
    {
        protected int x;
        protected int y;
        protected int size = 75;
        protected SolidColorBrush brush =
            new SolidColorBrush(Colors.Black);

        public abstract void DisplayOn(Canvas drawArea);
    }
}
