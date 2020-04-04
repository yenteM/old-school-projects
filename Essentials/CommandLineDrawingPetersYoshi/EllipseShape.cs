using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CommandLineDrawing
{
    public class EllipseShape : Shape
    {
        public override UIElement drawShape()
        {
            Ellipse el = new Ellipse();

            el.Margin = new Thickness(X, Y, 0, 0);
            el.Width = Width;
            el.Height = Height;

            if(isFilled)
            {
                el.Fill = new SolidColorBrush(ShapeColor);
            }

            el.Stroke = new SolidColorBrush(ShapeColor);

            return el;
        }
    }
}
