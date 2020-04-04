using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CyberspaceInvader
{
    public class Bomb : Sprite
    {
        private int stepSize;
        private Bombs bombs;
        private Ellipse ellipse;
        private Canvas canvas;
        
        public Bomb(int x, int y, Bombs bombs)
        {
            ellipse = new Ellipse();
            ellipse.Fill = new SolidColorBrush(Colors.Black);
            
            X = x;
            Y = y;
            Width = 5;
            Height = 5;
            stepSize = 1;
            this.bombs = bombs;
            bombs.Add(this);
        }

        public override void DisplayOn(Canvas drawingCanvas)
        {
            drawingCanvas.Children.Add(ellipse);
            this.canvas = drawingCanvas;
        }

        public void Move()
        {
            if (Y > 320)
            {
                bombs.Remove(this);
            }
            else
            {
                Y += stepSize;
            }
        }

        public void CheckHit(User user)
        {
            if ((X > user.X) &&
                (Y < (user.Y + user.Height)) &&
                ((X + Width) < (user.X + user.Width)) &&
                ((Y + Width) > (user.Y)))
            {
                bombs.Remove(this);
                user.Dead = true;
            }
        }

        protected override void UpdateElement()
        {
            ellipse.Width = Width;
            ellipse.Height = Height;
            ellipse.Margin = new Thickness(X, Y, 0, 0);
        }
    }
}
