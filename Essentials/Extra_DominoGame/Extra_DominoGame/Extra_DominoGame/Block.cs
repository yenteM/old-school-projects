using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Extra_DominoGame
{
    public class Block
    {
        private readonly Rectangle _block;
        private readonly double _width;
        private readonly double _height;
        private readonly double _x;
        private readonly double _y;
        
        public int Row { get; }
        public int Column { get; }

        public Block(int boardDimension, Canvas drawCanvas, int row, int column)
        {
            Row = row;
            Column = column;

            _width = drawCanvas.ActualWidth / boardDimension;
            _height = drawCanvas.ActualHeight / boardDimension;
            _y = row* _height;
            _x = column * _width;
            Thickness thick = new Thickness(_x, _y, 0, 0);

            _block = new Rectangle
            {
                Width = _width,
                Height = _height,
                Fill = new SolidColorBrush(Colors.DarkGreen),
                Stroke = new SolidColorBrush(Colors.Black),
                StrokeThickness = 1,
                Margin = thick 
            };
            drawCanvas.Children.Add(_block);
        }

        public bool ContainsPoint(Point point)
        {
            if (!(point.X >= _x) || !(point.X <= _x + _width) || !(point.Y >= _y) ||
                !(point.Y <= _y + _height)) return false;
            return true;
        }

        public void FillColor(Color color)
        {
                _block.Fill = new SolidColorBrush(color);
        }
        public Boolean CheckBlockColor() {
            return _block.Fill.ToString().Contains("#FF006400");
        }

    }
}
