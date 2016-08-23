using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApplication1
{
    public class PeopleRepository
    {
        public PeopleRepository()
        { }
        public IEnumerable<Person> GetAll()
        {
            //var IEnumerable<Person> myPerson;
            IEnumerable<Person> Persons = new Person[] {};
            return Persons;        
        }

    }
}
