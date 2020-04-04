using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Student
    {
        private string firstname;
        private string lastname;
        private string street;
        private string city;
        private string state;
        private int zip;
        private string phone;
        private string cell;

        public Student(string firstname, string lastname, string street, string city, string state, int zip, string phone, string cell)
        {
            Firstname = firstname;
            Lastname = lastname;
            Street = street;
            City = city;
            State = state;
            Zip = zip;
            Phone = phone;
            Cell = cell;
        }

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public int Zip
        {
            get { return zip; }
            set { zip = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Cell
        {
            get { return cell; }
            set { cell = value; }
        }







    }
}
