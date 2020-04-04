using System;
using System.Collections.Generic;
using System.Text;

namespace AskFrasierApp
{
    public class Frasier
    {
        public string GetReply(string question)
        {
            Random randomNumber = new Random();
            int variation = randomNumber.Next(0, 3);
            string reply;
            question = " " + question + " ";
            if (variation == 0)
            {
                reply = Transform(question);
            }
            else if (variation == 1)
            {
                reply = "Why do you feel that?";
            }
            else
            {
                reply = "Please be frank!";
            }
            return reply;
        }

        public string Transform(string question)
        {
            string tempReply;
            if (question.IndexOf(" I ") >= 0)
            {
                tempReply = Change(question, " I ", " you ");
                tempReply = Change(tempReply, " am ", " are ");
                return Change(tempReply, " my ", " your ") + " - why?";
            }
            else if (question.IndexOf(" no ") >= 0)
            {
                return "'no'? - that is negative! Please explain.";
            }
            else
            {
                return "'" + question + "'  - Please explain.";
            }
        }

        private string Change(string original, string fromText, string toText)
        {

            string leftBit, rightBit;
            int startSearch = 0;
            int place = original.IndexOf(fromText);

            if (fromText.Length != 0)
            {
                while (place >= startSearch)
                {
                    leftBit = original.Substring(0, place);
                    rightBit = original.Substring(place + fromText.Length,
                                            original.Length - place - fromText.Length);
                    original = leftBit + toText + rightBit;
                    startSearch = leftBit.Length + toText.Length;
                    place = original.IndexOf(fromText);
                }
            }
            return original;
        }
    }
}
