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
                Console.WriteLine("Введите необходимую клавишу " +
                                  "чтобы исполнить команду");
                Console.WriteLine("0 - Выход");
                Console.WriteLine("1 - Вывести информацию о всех студентов");
                Console.WriteLine("2 - Вывести информацию о всех преподавателях");
                Console.WriteLine("3 - Вывести информацию о всех людях");
                Console.WriteLine("4 - Найти по фамилии");
                Console.WriteLine("5 - Найти по среднему баллу");
                Console.WriteLine("6 - Удалить пользователя");
                Console.WriteLine("7 - Добавить пользователя");

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
                        Console.WriteLine("Введите фамилию: ");
                        var lastName = Console.ReadLine();
                        foreach (var person in university.FindByLastName(lastName))
                        {
                            Console.WriteLine(person.ToString());
                        }
                        break;
                    case 5:
                        Console.WriteLine("Введите средний балл: ");
                        var avgPoint = float.Parse(Console.ReadLine());
                        foreach (var student in university.FindByAvgPoint(avgPoint))
                        {
                            Console.WriteLine(student.ToString());
                        }
                        break;
                    case 6:
                        Console.WriteLine("Введите фамилию: ");
                        lastName = Console.ReadLine();
                        Console.WriteLine("Введите имя: ");
                        var name = Console.ReadLine();
                        Console.WriteLine("Это студент? Да или нет");
                        var isStudentInput = Console.ReadLine();
                        IOrderedEnumerable<IPerson> personList;
                        if (isStudentInput == "да" || isStudentInput == "Да")
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
                        Console.WriteLine("Это студент? Да или нет");
                        isStudentInput = Console.ReadLine();
                        if (isStudentInput == "да" || isStudentInput == "Да")
                        {
                            Console.WriteLine("Введите фамилию: ");
                            lastName = Console.ReadLine();
                            Console.WriteLine("Введите имя: ");
                            name = Console.ReadLine();
                            Console.WriteLine("Введите отчество: ");
                            var patronymic = Console.ReadLine();
                            Console.WriteLine("Введите дату рождения: ");
                            var date = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Введите курс: ");
                            var course = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите группу: ");
                            var group = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите средний балл: ");
                            avgPoint = float.Parse(Console.ReadLine());

                            university.Add(new Student(lastName, name, patronymic,
                                                       date, course, group, avgPoint));
                        }
						else
						{
                            Console.WriteLine("Введите фамилию: ");
                            lastName = Console.ReadLine();
                            Console.WriteLine("Введите имя: ");
                            name = Console.ReadLine();
                            Console.WriteLine("Введите отчество: ");
                            var patronymic = Console.ReadLine();
                            Console.WriteLine("Введите дату рождения: ");
                            var date = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Введите факультет: ");
                            var faculty = Console.ReadLine();
                            Console.WriteLine("Введите опыт работы: ");
                            var experience = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите должность: ");
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
