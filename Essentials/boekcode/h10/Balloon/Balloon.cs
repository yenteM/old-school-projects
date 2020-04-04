using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace BalloonApp
{
    public class Balloon
    {
        private int x = 50;
        private int y = 50;
        private int diameter = 20;
        private Ellipse ellipse;
        //private Color color = Colors.Blue;

        public Balloon()
        {
            x = 50;
            y = 50;
            diameter = 20;

            CreateEllipse();
            UpdateEllipse();
        }

        public Balloon(int initialX)
        {
            x = initialX;
            y = 50;
            diameter = 20;

            CreateEllipse();
            UpdateEllipse();
        }

        public Balloon(int initialX, int initialY)
        {
            CreateEllipse();
            UpdateEllipse();
        }

        public Balloon(int initialX,
                       int initialY,
                       int initialDiameter)
        {
            x = initialX;
            y = initialY;
            diameter = initialDiameter;

            CreateEllipse();
            UpdateEllipse();
        }

        public void MoveRight(int xStep)
        {
            x = x + xStep;
            UpdateEllipse();
        }

        public void ChangeSize(int change)
        {
            diameter = diameter + change;
            UpdateEllipse();
        }

        public void DisplayOn(Canvas drawingCanvas)
        {
            drawingCanvas.Children.Add(ellipse);
        }

        public double Area
        {
            get
            {
                return this.CalcArea();
            }
        }

        private double CalcArea()
        {
            double radius;
            radius = diameter / 2.0;
            return Math.PI * radius * radius;
        }

        private void CreateEllipse()
        {
            ellipse = new Ellipse();
            ellipse.Stroke = new SolidColorBrush(Colors.Blue);
            //ellipse.Stroke = new SolidColorBrush(color);
            ellipse.StrokeThickness = 2;
        }

        private void UpdateEllipse()
        {
            ellipse.Margin = new Thickness(x, y, 0, 0);
            ellipse.Width = diameter;
            ellipse.Height = diameter;
            //ellipse.Stroke = new SolidColorBrush(color);
        }
    }
}
