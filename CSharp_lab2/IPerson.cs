using System;
namespace CSharp_lab2
{
   public interface IPerson
   {
      string LastName { get; }
      string FirstName { get; }
      string MidName { get; }
      DateTime Date { get; }
      int Age { get; }
      string FormString();

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
   }
}
