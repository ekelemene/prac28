using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac28
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Иван","Баран",100);
            person1.Output();

            Employee employee1 = new Employee("foidsfjds","sodfosdj",231,"sdfjsd","fsjdfo");
            employee1.Output2();

            Person personEmployee = new Employee("Сергей", "Сергеев", 28, "ООО Компания", "Разработчик");
            personEmployee.Output();

            Person[] people = new Person[]
        {
            new Person("Александр", "Васильев", 22),
            new Employee("Николай", "Сидоров", 35, "XYZ Corp", "Тестировщик"),
            new Student("Мария", "Смирнова", 19, "Программирование", new DateTime(2004, 6, 10)) }; 

            Console.WriteLine("\nОбъекты в массиве:");
            foreach (var person in people)
            {
                person.Output();  // Вывод состояния объекта
                Console.WriteLine();
            }

            List<Person> personList = new List<Person>()
            {
            new Employee("Игорь", "Михайлов", 40, "Tech Solutions", "Архитектор"),
            new Student("Алена", "Кузнецова", 20, "Физика", new DateTime(2002, 3, 15))
            };

            Console.WriteLine("\nОбъекты в коллекции:");
            foreach (var person in personList)
            {
                person.Output();  // Вывод состояния объекта
                Console.WriteLine();
            }

            Console.ReadLine();




        }
    }
}
