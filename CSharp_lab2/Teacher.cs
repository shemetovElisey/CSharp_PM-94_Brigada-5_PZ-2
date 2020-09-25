using System;
namespace CSharp_lab2
{
    public class Teacher
    {
        public string LastName { get; }
        public string FirstName { get; }
        public string MidName { get; }
        public DateTime Date { get; }
        public int Age { get; }

        public Teacher(
            string lName, string fName, string mName, DateTime date, int age)
        {
            this.LastName = lName;
            this.FirstName = fName;
            this.MidName = mName;
            this.Date = date;
            this.Age = age;
        }

        public string FormString()
        {
            throw new NotImplementedException();
        }
    }
}
