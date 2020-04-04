using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CyberspaceInvader
{
    public class Alien : Sprite
    {
        private Image alienImage;
        private int stepSize;
        private Canvas canvas;

        public Alien()
        {
            alienImage = new Image();
            alienImage.Source = CreateBitmap(@"Assets\Alien.gif");
            
            X = 20;
            Y = 20;
            Width = 25;
            Height = 25;
            stepSize = 1;
            Dead = false;
        }

        public bool Dead { get; set; }
        
        public override void DisplayOn(Canvas drawingCanvas)
        {
            drawingCanvas.Children.Add(alienImage);
            this.canvas = drawingCanvas;
        }

        public void Move()
        {
            if ((X > 480) || (X < 0))
            {
                stepSize = -stepSize;
            }
            X += stepSize;
        }

        public void CheckHit(Lasers lasers)
        {
            lasers.CheckHit(this);
        }

        public void Launch(Bombs bombs)
        {
            Bomb bomb = new Bomb(X + (Width / 2), Y + Height, bombs);
            bomb.DisplayOn(canvas);
        }

        protected override void UpdateElement()
        {
            alienImage.Margin = new Thickness(X, Y, 0, 0);
            alienImage.Width = Width;
            alienImage.Height = Height;
        }
    }
}
