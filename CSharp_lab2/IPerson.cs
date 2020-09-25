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
    }
}
