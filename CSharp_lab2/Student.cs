using System;

namespace CSharp_lab2
{
    public class Student : IPerson
    {

        public string LastName { get; }
        public string Name { get; }
        public string Patronymic { get; }
        public DateTime Date { get; }
        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - Date.Year;

                if (DateTime.Now.Month > Date.Month)
                    return Convert.ToByte(age);
                else
                    return Convert.ToByte(DateTime.Now.Date < Date.Date ?
                       age - 1 : age);
            }
        }
        public int Course { get; }
        public int Group { get; }
        public float AvgPoint { get; }

        public Student(string lastName, string name, string patronymic, DateTime date,
                       int course, int group, float avgPoint)
        {
            LastName = lastName;
            Name = name;
            Patronymic = patronymic;
            Date = date;
            Group = group;
            Course = course;
            AvgPoint = avgPoint;
        }

        public static Student Parse(string inputStr)
        {
            var splittedStr = inputStr.Split(' ');

            var lastName = splittedStr[0];
            var name = splittedStr[1];
            var patronymic = splittedStr[2];
            var date = DateTime.Parse(splittedStr[3]);
            var course = int.Parse(splittedStr[4]);
            var group = int.Parse(splittedStr[5]);
            var avgPoint = float.Parse(splittedStr[6]);

            var student = new Student(lastName, name, patronymic, date, course, group,
                                      avgPoint);
            return student;
        }

        public override string ToString()
        {
            return $"Студент: {LastName} {Name} {Patronymic}, возраст: {Age}, курс: {Course}, " +
                   $"группа: {Group}, средний балл: {AvgPoint}";
        }
    }
}
