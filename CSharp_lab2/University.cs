using System;
using System.Collections.Generic;

namespace CSharp_lab2
{
	public class University : IUniversity
	{
		public University()
		{
		}

      public IEnumerable<IPerson> Persons => throw new NotImplementedException();

      public IEnumerable<Student> Students => throw new NotImplementedException();

      public IEnumerable<Teacher> Teachers => throw new NotImplementedException();

      public void Add(IPerson person)
      {
         throw new NotImplementedException();
      }

      public IEnumerable<Student> FindByAvrPoint(float avrPoint)
      {
         throw new NotImplementedException();
      }

      public IEnumerable<IPerson> FindByLastName(string lastName)
      {
         throw new NotImplementedException();
      }

      public void Remove(IPerson person)
      {
         throw new NotImplementedException();
      }
   }
}
