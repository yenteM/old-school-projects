using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Presidents : ObservableCollection<President>
    {
        public Presidents()
        {
            Add(new President("Pictures\\gw1.jpg", "George Washington"));
            Add(new President("Pictures\\ja2.jpg", "John Adams"));
            Add(new President("Pictures\\tj3.jpg", "Thomas jefferson"));
        }
        
    }
}
