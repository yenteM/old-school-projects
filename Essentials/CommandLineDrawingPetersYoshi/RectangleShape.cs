using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CommandLineDrawing
{
    public class RectangleShape : Shape
    {
        public override UIElement drawShape()
        {
            Rectangle rect = new Rectangle();

            rect.Margin = new Thickness(X, Y, 0, 0);
            rect.Width = Width;
            rect.Height = Height;

            if (isFilled)
            {
                rect.Fill = new SolidColorBrush(ShapeColor);
            }

            rect.Stroke = new SolidColorBrush(ShapeColor);

            return rect;
        }
    }
}
