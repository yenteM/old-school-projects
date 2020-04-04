using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class President
    {
        private string source;
        private string name;

        public President(string source, string name)
        {
            Source = source;
            Name = name;
        }

        public string Source
        {
            get { return source; }
            set { source = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
