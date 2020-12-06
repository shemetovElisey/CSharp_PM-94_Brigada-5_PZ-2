using System;

namespace CSharp_lab2
{
    public interface IPerson
    {
        string Name { get; }
        string Patronymic { get; }
        string LastName { get; }
        int Age { get; }
        DateTime Date { get; }
    }
}
