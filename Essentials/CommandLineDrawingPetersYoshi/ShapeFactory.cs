using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CommandLineDrawing
{
    public static class ShapeFactory
    {

        public static UIElement CreateShape(string command, string shape, string param, string color)
        {
            Shape ourShape = null;

            string[] tempParamItems = param.Split(',');

            switch (shape)
            {
                case "rechthoek":
                    ourShape = new RectangleShape();
                    break;
                case "ellips":
                    ourShape = new EllipseShape();
                    break;
            }

            ourShape.X = Convert.ToInt32(tempParamItems[0]);
            ourShape.Y = Convert.ToInt32(tempParamItems[1]);
            ourShape.Width = Convert.ToInt32(tempParamItems[2]);
            ourShape.Height = Convert.ToInt32(tempParamItems[3]);

            ourShape.ShapeColor = (Color)ColorConverter.ConvertFromString(color);

            ourShape.isFilled = command.Equals("vul");

            return ourShape.drawShape();
        }



    }
}
