using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Services.Common;

namespace WebApplication1
{
    [DataServiceKey("Id")]
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LAstName { get; set; }
    }
}