using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Extra_DominoGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Board _domino;
        private readonly Moves _movesWindow;

        public MainWindow()

        {
            InitializeComponent();
            _movesWindow = new Moves();
            drawCanvas.MouseUp += MouseClick;
        }

        private void ExitItem_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void StartGame_Click(object sender, RoutedEventArgs e)
        {
           drawCanvas.Children.Clear();
           int boardDimension = Convert.ToInt32(((MenuItem)sender).Header.ToString().Split('x')[0]);
           _domino = new Board(boardDimension, drawCanvas);
        }

        private void MouseClick(object sender, MouseButtonEventArgs e)
        {
            xCoordinateLabel.Content = $"{e.GetPosition(drawCanvas).X:N2}";
            yCoordinateLabel.Content = $"{e.GetPosition(drawCanvas).Y:N2}";

            try {
                _domino.ColorBlock(e.GetPosition(drawCanvas));
                blockLabel.Content = _domino.GetBlokPosition();

                if (this._domino.IsMovePossible())
                {
                    turnLabel.Content = $"It's Player's {_domino.CurrentPlayer} turn.";
                } else
                {
                    MessageBox.Show($"It's the end of the game! Player {_domino.CurrentPlayer} lost");
                    turnLabel.Content = $"Player {_domino.CurrentPlayer} lost!";
                    _domino.EndGame();
                    ShowMoves.IsEnabled = true;
                }
            }
            catch (DominoException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowMoves_Click(object sender, RoutedEventArgs e)
        {
            string movesDestination = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string newFile = System.IO.Path.Combine(movesDestination, "domino.txt");
            StreamReader movesInput;
            using (movesInput = File.OpenText(newFile))
            {
                string line = movesInput.ReadToEnd();
                if (_movesWindow != null) _movesWindow?.MovesTextBox.AppendText(line);
                movesInput.Close();
            }

            if (_movesWindow != null) _movesWindow.ShowDialog();
        }
    }
}
