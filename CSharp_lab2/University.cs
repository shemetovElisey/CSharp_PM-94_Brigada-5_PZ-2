using System.Collections.Generic;
using System.Linq;

namespace CSharp_lab2
{
    public class University : IUniversity
    {
        public IEnumerable<IPerson> Persons => _people.OrderBy((x) => x.LastName);

        public IEnumerable<Student> Students =>
            from person in Persons
            where person is Student
            orderby person.LastName
            select person as Student;

        public IEnumerable<Teacher> Teachers =>
            from person in Persons
            where person is Teacher
            orderby person.LastName
            select person as Teacher;

        public void Add(IPerson person)
        {
            _people.Add(person);
        }

        public IEnumerable<Student> FindByAvgPoint(float avgPoint) =>
            from student in Students
            where student.AvgPoint >= avgPoint
            orderby student.AvgPoint
            select student;

        public IEnumerable<IPerson> FindByLastName(string lastName) =>
            from person in Persons
            where person.LastName == lastName
            select person;

        public void Remove(IPerson person)
        {
            _people.Remove(person);
        }

        private List<IPerson> _people = new List<IPerson>();
    }
}
