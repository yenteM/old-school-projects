using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }


        public static int GetTotalAge(List<Person> personList)
        {
            var totalAge = 0;

            foreach (var person in personList)
            {
                totalAge += person.Age;
            }

            return totalAge;
        }
    }
}
