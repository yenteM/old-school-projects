using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows;

namespace SphereAndBubble
{
    public class Sphere
    {
        protected int xCoord = 100;
        protected int yCoord = 100;
        protected Ellipse ellipse;

        public int X
        {
            set { xCoord = value; UpdateEllipse(); }
        }

        public int Y
        {
            set { yCoord = value; UpdateEllipse(); }
        }

        public virtual void CreateEllipse(Canvas drawingCanvas)
        {
            ellipse = new Ellipse();
            ellipse.Stroke = new SolidColorBrush(Colors.Black);
            ellipse.StrokeThickness = 2;
            ellipse.Width = 40;
            ellipse.Height = 40;
            ellipse.Margin = new Thickness(xCoord, yCoord, 0, 0);
            
            drawingCanvas.Children.Add(ellipse);
        }

        public virtual void UpdateEllipse()
        {
            if (ellipse != null)
            {
                ellipse.Margin = new Thickness(xCoord, yCoord, 0, 0);
            }
        }

    }
}
