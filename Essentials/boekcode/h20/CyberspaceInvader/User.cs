using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CyberspaceInvader
{
    public class User : Sprite
    {
        private Image userImage;

        public User()
        {
            userImage = new Image();
            userImage.Source = CreateBitmap(@"Assets\User.gif");
            
            X = 10;
            Y = 260;
            Width = 20;
            Height = 20;
            Dead = false;
        }

        public bool Dead { get; set; }

        public override void DisplayOn(Canvas drawingCanvas)
        {
            drawingCanvas.Children.Add(userImage);    
        }

        public void Move(int x)
        {
            X = x;
        }

        protected override void UpdateElement()
        {
            userImage.Margin = new System.Windows.Thickness(X, Y, 0, 0);
            userImage.Width = Width;
            userImage.Height = Height;
        }
    }
}
