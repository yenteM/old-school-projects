using System;
using System.Collections.Generic;
using System.Windows.Media;

namespace CommandLineDrawing
{
    public static class CommandParser
    {
        public static Dictionary<string, string> parse(string command)
        {
            /*
             *  Possible commands are:
             *  - teken <vorm> <params> <kleur>
             *  - vul <vorm> <params> <kleur>
             *  - undo
             *  - clear
             */

            string[] commandItems = command.Split(' ');
            Dictionary<string, string> commandItemsDic = new Dictionary<string, string>();

            // Check the actual command 
            switch (commandItems[0])
            {
                case "teken":
                case "vul":

                    // We need to check more than only the first item
                    // Check the shape, params, color
                    if (isValidShape(commandItems[1])) {
                        commandItemsDic.Add("shape", commandItems[1]);
                    }

                    if (isValidParams(commandItems[2]))
                    {
                        commandItemsDic.Add("params", commandItems[2]);
                    }

                    if ( isValidColor(commandItems[3]))
                    {
                        commandItemsDic.Add("color", commandItems[3]);
                    }

                    commandItemsDic.Add("command", commandItems[0]);
                    break;
                case "undo":
                case "clear":
                    commandItemsDic.Add("command", commandItems[0]);
                    break;
                default:
                    throw new IllegalCommandException(commandItems[0] + " is een ongeldig commando!");

            }

            return commandItemsDic;

            // /
        }

        private static bool isValidShape(string shape)
        {
            // Shape can only be: rechthoek, ellips
            int i = 0;
            bool isFound = false;
            string[] allowedShapes = { "rechthoek", "ellips" };

            while(!isFound && i < allowedShapes.Length)
            {
                if (allowedShapes[i].Equals(shape))
                    isFound = true;
                i++;
            }

            if (!isFound)
            {
                throw new IllegalShapeException(shape + " is een obekende vorm.");
            } else
            {
                return true;
            }   
        }

        private static bool isValidParams(string param)
        {
            // Param markup: x y width height, these must all be intergers and are sperated by ,
            string[] paramItems = param.Split(',');

            if (paramItems.Length < 4)
            {
                throw new IllegalCommandException("Onvoldoende parameters.");
            } else if (paramItems.Length > 4)
            {
                throw new IllegalCommandException("Teveel parameters.");
            }

            // All 4 numbers must be an int zo we try to convert them

            // Coordinaten
            try
            {
                Convert.ToInt32(paramItems[0]);
                Convert.ToInt32(paramItems[1]);
            } catch(Exception)
            {
                throw new IllegalCommandException("Geen numerieke waarden voor de coïrdinaten.");
            }

            try
            {
                Convert.ToInt32(paramItems[2]);
                Convert.ToInt32(paramItems[3]);
            }
            catch (FormatException)
            {
                throw new IllegalCommandException("Geen numerieke waarden voor de hoogte en breedte.");
            }

            return true;
        }

        private static bool isValidColor(string color)
        {
            // A know color in the Colors class
            if (ColorConverter.ConvertFromString(color) == null)
            {
                throw new IllegalCommandException("Ongeldige kleurwaarde " + color);
            }
            
            return true;
        }
    }
}
