using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace CommandLineDrawing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window   
    {
        Dictionary<string, string> commandItems;

        public MainWindow()
        {
            InitializeComponent();
            commandTextBox.Focus();
        }

        private void commandTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return) // de gebruiker drukt op ENTER
            {
                // Selecteer ingegeven commando
                commandTextBox.SelectAll();

                // Get the command, trim it of leading and trailing spaces and remove capitals
                string command = commandTextBox.Text.Trim().ToLower();

                // Try to parse the command and act on exception
                try
                {
                    commandItems = CommandParser.parse(command);

                    // Act on one of the 4 commands
                    switch (commandItems["command"])
                    {
                        case "teken":
                        case "vul":
                            paperCanvas.Children.Add(ShapeFactory.CreateShape(
                                commandItems["command"],
                                commandItems["shape"],
                                commandItems["params"],
                                commandItems["color"]));
                            break;
                        case "undo":
                            undoLastDrawFromCanvas();
                            break;
                        case "clear":
                            clearCanvas();
                            break;

                    }
                } catch(IllegalCommandException ex)
                {
                    MessageBox.Show(ex.Message, "Ongeldig commando", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                } catch (IllegalShapeException ex)
                {
                    MessageBox.Show(ex.Message, "Ongeldige vorm", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                }

                
            }
        }
        
        
        private void clearCanvas()
        {
            paperCanvas.Children.Clear();
        }

        private void undoLastDrawFromCanvas()
        {
            int nDrawings = paperCanvas.Children.Count;
            paperCanvas.Children.RemoveAt(nDrawings - 1);
        }


        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Openen
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            openFileDialog.Filter = "Text Files|*.TXT;";

            string fileName = null; ;

            if (openFileDialog.ShowDialog() == true)
            {
                fileName = openFileDialog.FileName;
            }

            IList<UIElement> shapeList;
            shapeList = FileHandler.readFromFile(fileName);

            foreach(UIElement shape in shapeList)
            {
                paperCanvas.Children.Add(shape);
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            // Opslaan als
            SaveFileDialog openFileDialog = new SaveFileDialog();
            openFileDialog.Filter = "Text Files|*.TXT;";

            string fileName = null; ;

            if (openFileDialog.ShowDialog() == true)
            {
                fileName = openFileDialog.FileName;
            }

            IList<UIElement> shapeList = new List<UIElement>();
            foreach (UIElement shape in paperCanvas.Children)
            {
                shapeList.Add(shape);
            }

            FileHandler.saveToFile(fileName, shapeList);
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            // Sluiten
            Environment.Exit(0);
        }
    }
}
