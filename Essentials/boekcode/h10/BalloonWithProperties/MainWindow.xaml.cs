﻿using System;
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

namespace BalloonWithProperties
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Balloon balloon;
        
        public MainWindow()
        {
            InitializeComponent();

            balloon = new Balloon();
            balloon.DisplayOn(drawingCanvas);
        }

        private void moveButton_Click(object sender, RoutedEventArgs e)
        {
            balloon.MoveRight(20);
        }

        private void growButton_Click(object sender, RoutedEventArgs e)
        {
            balloon.ChangeSize(20);
        }

        private void displayXButton_Click(object sender, RoutedEventArgs e)
        {
            xCoordTextBox.Text = Convert.ToString(balloon.XCoord);
        }

        private void changeXButton_Click(object sender, RoutedEventArgs e)
        {
            balloon.XCoord = Convert.ToInt32(xCoordTextBox.Text);
        }
    }
}
