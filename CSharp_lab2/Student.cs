using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_lab2
{
   public class Student : IPerson
   {
      public string LastName { get; }
      public string FirstName { get; }
      public string MidName { get; }
      public DateTime Date { get; }
      public int Age { get; }
      public byte Course { get; }
      public byte Group { get; }
      public double Avg { get; }

      public Student(string lName, string fName, string mName, DateTime date, byte course, byte group, List<int> avg)
      {
         this.LastName = lName;
         this.FirstName = fName;
         this.MidName = mName;
         this.Date = date;
         this.Age = GetAge(date);
         this.Group = group;
         this.Course = course;
         this.Avg = avg.Average();
      }

      private int GetAge(DateTime birthDate)
      {
         try
         {
            int age = DateTime.Now.Year - birthDate.Year;

            if (DateTime.Now.Month > birthDate.Month)
               return Convert.ToByte(age);
            else
               return Convert.ToByte(DateTime.Now.Date < birthDate.Date ?
                  age - 1 : age);
         }

         catch (OverflowException)
         {
            Console.WriteLine("Возраст больше 255 или меньше 0");
            throw;
         }
      }

      public string FormString()
      {
         Console.WriteLine($"Student: {LastName, -9}{FirstName, -9}{MidName, -9}{Age, -5}{Course, -5}{Group, -5}{Avg, -5}");
      }
   }
}
