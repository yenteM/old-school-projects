using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            persons.Add(new Person
            {
                Age = 22,
                Name = "yente"
            });

            persons.Add(new Person
            {
                Age = 25,
                Name = "niet yente"
            });

            persons.Add(new Person
            {
                Age = 52,
                Name = "oude yente"
            });

            persons.Add(new Person
            {
                Age = 3,
                Name = "baby yente"
            });

            Person dodeYente = new Person();
            dodeYente.Name = "dode yente";
            dodeYente.Age = 132;
            persons.Add(dodeYente);


            //Console.WriteLine(Person.GetTotalAge(persons));
            //Console.ReadLine();

            var app = new Application {Visible = true};
            app.Documents.Add();
            Microsoft.Office.Interop.Word.Range rng = app.Application.ActiveDocument.Range(0, 0);

            foreach (var person in persons)
            {
                rng.Text += $"{person.Name} is {person.Age} jaar oud. \n";
            }

        }
    }
}
