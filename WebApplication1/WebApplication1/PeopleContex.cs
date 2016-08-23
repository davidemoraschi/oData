using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Data.Services.Toolkit.QueryModel;

namespace WebApplication1
{
    public class PeopleContex : ODataContext
    {
        public IQueryable<Person> People
        {
            get { return base.CreateQuery<Person>(); }
        }

        public override object RepositoryFor(string fullTypeName)
        {
            if (fullTypeName == typeof(Person).FullName)
                return new PeopleRepository();

            return null;
        }
    }
}