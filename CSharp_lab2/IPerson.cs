using System;

namespace CSharp_lab2
{
    public interface IPerson
    {
        string Name { get; }
        string Patronymic { get; }
        string LastName { get; }
        int Age
        {
            get
            {
                try
                {
                    int age = DateTime.Now.Year - Date.Year;

                    if (DateTime.Now.Month > Date.Month)
                        return Convert.ToByte(age);
                    else
                        return Convert.ToByte(DateTime.Now.Date < Date.Date ?
                           age - 1 : age);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Возраст больше 255 или меньше 0");
                    throw;
                }
            }
        }
        DateTime Date { get; }
    }
}
