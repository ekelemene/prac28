using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac28
{
    class Employee : Person
    {
        private string nameenterprise;
        private string employeeposition;

        public string Nameenterprise { get => nameenterprise; set => nameenterprise = value; }
        public string Employeeposition { get => employeeposition; set => employeeposition = value; }

        public Employee() { }
        public Employee(string name, string surname, int age, string nameenterprice, string employeeposition)
            :base(name, surname, age)
        {
            this.Nameenterprise = nameenterprice;
            this.Employeeposition = employeeposition;
        }
        public void Output2()
        {
            Output();
            Console.WriteLine($"nameenterprise: {Nameenterprise} eployeeposition: {Employeeposition}");
        }






    }
}
