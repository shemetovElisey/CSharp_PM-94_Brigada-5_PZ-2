using System;

namespace CSharp_lab2
{
    public class Teacher : IPerson
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
        public string Faculty { get; }
        public int Experience { get; }
        public Positions Position { get; }

        public Teacher(string lastName, string name, string patronymic, DateTime date,
                       string faculty, int experience, Positions position)
        {
            LastName = lastName;
            Name = name;
            Patronymic = patronymic;
            Date = date;
            Faculty = faculty;
            Experience = experience;
            Position = position;
        }

        public static Teacher Parse(string inputStr)
        {
            var splittedStr = inputStr.Split(' ');

            var lastName = splittedStr[0];
            var name = splittedStr[1];
            var patronymic = splittedStr[2];
            var date = DateTime.Parse(splittedStr[3]);
            var faculty = splittedStr[4];
            var experience = int.Parse(splittedStr[5]);
			var position = (Positions)Enum.Parse(typeof(Positions), splittedStr[6]);

            var teacher = new Teacher(lastName, name, patronymic, date, faculty, experience, position);
            return teacher;
        }

        public override string ToString()
        {
            return $"Преподаватель: {LastName} {Name} {Patronymic}, возраст: {Age}, факультет: {Faculty}, " +
                   $"опыт работы: {Experience}, должность: {Position}";
        }
    }

    public enum Positions
    {
        профессор,
        доцент,
        научныйСотрудник,
        старшийНаучныйСотрудник,
        лектор
    }
}
