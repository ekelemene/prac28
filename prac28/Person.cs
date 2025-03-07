using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac28
{
    class Person
    {
        private string name;
        private string surname;
        private int age;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }

        public Person() { }
        public Person(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public void Output()
        {
            Console.WriteLine($"name: {Name} surname: {Surname} age: {Age}");
        }






    }
}
