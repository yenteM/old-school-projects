using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;

namespace CommandLineDrawing
{
    public static class FileHandler
    {

        public static IList<UIElement> readFromFile(string filename)
        {
            IList<UIElement> shapeList = new List<UIElement>();
            Dictionary<string, string> commandItems = null;
            StreamReader reader = null;

            try
            {
                FileStream fstream = new FileStream(filename, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(fstream);
                string line = reader.ReadLine();
                while (line != null)
                {
                    commandItems = CommandParser.parse(line);
                    if (commandItems["command"].Equals("teken") || commandItems["command"].Equals("vul"))
                    {
                        shapeList.Add(ShapeFactory.CreateShape(
                                commandItems["command"],
                                commandItems["shape"],
                                commandItems["params"],
                                commandItems["color"]));

                    }
                    line = reader.ReadLine();
                }
            }
            catch (FileNotFoundException)
            {
                throw new IllegalCommandException(filename + " niet gevonden!");
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(filename + " bevat een fout:" + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }

            return shapeList;
        }

        public static void saveToFile(string fileName, IList<UIElement> shapeList)
        {
            throw new NotImplementedException();
        }
    }
}
