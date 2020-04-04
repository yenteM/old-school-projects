using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CommandLineDrawing
{
    public abstract class Shape
    {
        // Params
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        // "Teken" or "vul"
        public bool isFilled { get; set; }

        public Color ShapeColor { get; set; }

        public abstract UIElement drawShape();
    }

}
