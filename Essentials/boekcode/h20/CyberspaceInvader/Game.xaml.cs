using System;
using System.Collections.Generic;
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
using System.Windows.Threading;

namespace CyberspaceInvader
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        private User user;
        private Alien alien;
        private Lasers lasers;
        private Bombs bombs;

        private DispatcherTimer animationTimer;
        private DispatcherTimer bombTimer;
        
        public Game()
        {
            InitializeComponent();

            user = new User();
            user.DisplayOn(gameCanvas);
            alien = new Alien();
            alien.DisplayOn(gameCanvas);
            lasers = new Lasers();
            bombs = new Bombs();

            animationTimer = new DispatcherTimer();
            animationTimer.Interval = TimeSpan.FromMilliseconds(50);
            animationTimer.Tick += animationTimer_Tick;
            animationTimer.IsEnabled = true;

            bombTimer = new DispatcherTimer();
            bombTimer.Interval = TimeSpan.FromSeconds(2);
            bombTimer.Tick += bombTimer_Tick;
            bombTimer.IsEnabled = true;
        }

        private void bombTimer_Tick(object sender, EventArgs e)
        {
            alien.Launch(bombs);
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            alien.Move();
            bombs.Move();
            lasers.Move();
            bombs.CheckHit(user);
            alien.CheckHit(lasers);

            if (alien.Dead)
            {
                EndGame("user");
            }
            if (user.Dead)
            {
                EndGame("alien");
            }
        }

        private void gameCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            user.Move((int)(e.GetPosition(this).X - 8));
        }

        private void gameCanvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            int x = user.X + user.Width / 2;
            int y = user.Y - user.Height;
            Laser laser = new Laser(x, y, lasers);
            laser.DisplayOn(gameCanvas);
        }

        private void EndGame(string winner)
        {
            animationTimer.IsEnabled = false;
            bombTimer.IsEnabled = false;
            MessageBox.Show("game over - " + winner + " wins");
            Environment.Exit(0);
        }
    }
}
