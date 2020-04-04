using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CyberspaceInvader
{
    public class Laser : Sprite
    {
        private int stepSize;
        private Lasers lasers;
        private Ellipse ellipse;
        private Canvas canvas;

        public Laser(int x, int y, Lasers lasers)
        {
            ellipse = new Ellipse();
            ellipse.Fill = new SolidColorBrush(Colors.Black);
            
            X = x;
            Y = y;
            Width = 5;
            Height = 10;
            stepSize = 1;
            this.lasers = lasers;
            lasers.Add(this);
        }
        
        public override void DisplayOn(Canvas drawingCanvas)
        {
            drawingCanvas.Children.Add(ellipse);
            this.canvas = drawingCanvas;
        }

        protected override void UpdateElement()
        {
            ellipse.Width = Width;
            ellipse.Height = Height;
            ellipse.Margin = new System.Windows.Thickness(X, Y, 0, 0);
        }

        public void Move()
        {
            if (Y < 10)
            {
                lasers.Remove(this);
                this.canvas.Children.Remove(ellipse);
            }
            else
            {
                Y -= stepSize;
            }
        }

        public void CheckHit(Alien alien)
        {
            if ((X > alien.X) &&
                (Y < (alien.Y + alien.Height)) &&
                (X + Width) < (alien.X + alien.Width) &&
                (Y + Height) > (alien.Y))
            {
                alien.Dead = true;
                lasers.Remove(this);
            }
        }
    }
}
