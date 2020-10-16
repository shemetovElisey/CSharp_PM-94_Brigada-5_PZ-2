using System;
using System.Linq;

namespace CSharp_lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            var university = new University();

            while (true)
            {
                Console.WriteLine("Please press necessart key " +
                                  "to execute the command");
                Console.WriteLine("0 - Exit");
                Console.WriteLine("1 - Print all the students");
                Console.WriteLine("2 - Print all the teacher");
                Console.WriteLine("3 - Print all the persons");
                Console.WriteLine("4 - Find by last name");
                Console.WriteLine("5 - Find by average point");
                Console.WriteLine("6 - Delete the user");
                Console.WriteLine("7 - Add the user");

                int input = int.Parse(Console.ReadLine());

                if (input == 0)
                {
                    break;
                }
                switch (input)
                {
                    case 1:
                        foreach (var student in university.Students)
                        {
                            Console.WriteLine(student);
                        }
                        break;
                    case 2:
                        foreach (var teacher in university.Teachers)
                        {
                            Console.WriteLine(teacher);
                        }
                        break;
                    case 3:
                        foreach (var person in university.Persons)
                        {
                            Console.WriteLine(person);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter the last name: ");
                        var lastName = Console.ReadLine();
                        foreach (var person in university.FindByLastName(lastName))
                        {
                            Console.WriteLine(person.ToString());
                        }
                        break;
                    case 5:
                        Console.WriteLine("Enter the average point: ");
                        var avgPoint = float.Parse(Console.ReadLine());
                        foreach (var student in university.FindByAvgPoint(avgPoint))
                        {
                            Console.WriteLine(student.ToString());
                        }
                        break;
                    case 6:
                        Console.WriteLine("Enter the last name: ");
                        lastName = Console.ReadLine();
                        Console.WriteLine("Enter the name: ");
                        var name = Console.ReadLine();
                        Console.WriteLine("Is this a student? yes or no");
                        var isStudentInput = Console.ReadLine();
                        IOrderedEnumerable<IPerson> personList;
                        if (isStudentInput == "yes")
                        {
                            personList = from student in university.Students
                                         where student.Name == name
                                         && student.LastName == lastName
                                         orderby student.LastName
                                         select student;
                        }
                        else
                        {
                            personList = from teacher in university.Teachers
                                         where teacher.Name == name
                                         && teacher.LastName == lastName
                                         orderby teacher.LastName
                                         select teacher;
                        }
                        foreach (var person in personList)
                        {
                            university.Remove(person);
                        }
                        break;
                    case 7:
                        Console.WriteLine("Is this a student? yes or no");
                        isStudentInput = Console.ReadLine();
                        if (isStudentInput == "yes")
                        {
                            Console.WriteLine("Enter the last name: ");
                            lastName = Console.ReadLine();
                            Console.WriteLine("Enter the name: ");
                            name = Console.ReadLine();
                            Console.WriteLine("Enter the patronymic: ");
                            var patronymic = Console.ReadLine();
                            Console.WriteLine("Enter the birth date: ");
                            var date = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the course: ");
                            var course = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the group: ");
                            var group = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the average point: ");
                            avgPoint = float.Parse(Console.ReadLine());

                            university.Add(new Student(lastName, name, patronymic,
                                                       date, course, group, avgPoint));
                        }
						else
						{
                            Console.WriteLine("Enter the last name: ");
                            lastName = Console.ReadLine();
                            Console.WriteLine("Enter the name: ");
                            name = Console.ReadLine();
                            Console.WriteLine("Enter the patronymic: ");
                            var patronymic = Console.ReadLine();
                            Console.WriteLine("Enter the birth date: ");
                            var date = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the faculty: ");
                            var faculty = Console.ReadLine();
                            Console.WriteLine("Enter the experience: ");
                            var experience = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the position: ");
                            var position = (Positions)Enum.Parse(typeof(Positions), Console.ReadLine());

                            university.Add(new Teacher(lastName, name, patronymic,
                                                       date, faculty, experience, 
                                                       position));
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
