using System.Collections.Generic;

namespace CSharp_lab2
{
   interface IUniversity
   {
      IEnumerable<IPerson> Persons { get; }  // Сортировка по принципу ПЗ1
      IEnumerable<Student> Students { get; }  // Сортировка по принципу ПЗ1
      IEnumerable<Teacher> Teachers { get; }  // Сортировка по принципу ПЗ1

      void Add(IPerson person);
      void Remove(IPerson person);

      IEnumerable<IPerson> FindByLastName(string lastName);

      // Для нечетных вариантов (нечетный номер бригады): 
      // Выдать всех студентов, чей средний балл выше заданного.
      // Отсортировать по среднему баллу.
      IEnumerable<Student> FindByAvrPoint(float avrPoint);
   }
}
