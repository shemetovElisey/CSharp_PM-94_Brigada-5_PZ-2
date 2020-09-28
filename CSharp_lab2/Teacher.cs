using System;
namespace CSharp_lab2
{
   public class Teacher : IPerson
   {
      public string LastName { get; }
      public string FirstName { get; }
      public string MidName { get; }
      public DateTime Date { get; }
      public int Age { get; }
      public string Cathedra { get; }
      public byte Exp { get; }
      public Positions Position { get; }



      public Teacher(string lName, string fName, string mName, DateTime date,
         string cathedra, byte exp, Positions position)
      {
         this.LastName = lName;
         this.FirstName = fName;
         this.MidName = mName;
         this.Date = date;
         this.Age = GetAge(date);
         this.Cathedra = cathedra;
         this.Exp = exp;
         this.Position = position;

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
         throw new NotImplementedException();
      }
   }

   public enum Positions
   {
      professor,
      associateProfessor,
      assistantProfessor,
      masterInstructor,
      seniorInstructor,
      instructor,
      lecturer,
      adjunctProfessor
   }
}
