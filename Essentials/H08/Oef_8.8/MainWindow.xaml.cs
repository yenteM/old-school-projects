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

namespace Oef_8._8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string fibonacci = "";
        int eerste = 1;
        int tweede = 1;
        int hulp;

        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i < 20; i++)
            {
                fibonacci = fibonacci + eerste + " ";
                hulp = eerste;
                eerste = tweede;
                tweede = hulp + eerste;                
            }

            fibonacciLabel.Content = fibonacci;

        }
    }
}
