using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac28
{
    class Student : Person
    {
        private string course;
        private DateTime birthDate;

        public string Course { get => course; set => course = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }

        public Student(string name, string surname, int age, string course, DateTime birthDate)
      : base(name, surname, age)
        {
            this.Course = course;
            this.BirthDate = birthDate;
        }

        // Метод для вывода информации о студенте
        public void OutputStudentInfo()
        {
            Output();  // Вызов метода Output() из базового класса
            Console.WriteLine($"Course: {Course}, Birth Date: {BirthDate}");
        }
    }
}




