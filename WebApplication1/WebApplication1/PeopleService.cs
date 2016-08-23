using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Data.Services.Toolkit;
using System.Data.Services;
using Microsoft.Data.Services;

namespace WebApplication1
{
    public class PeopleService : ODataService<PeopleContex>
    {
        public static void InitializeService(System.Data.Services.DataServiceConfiguration configuration)
        {
            configuration.SetEntitySetAccessRule("People", EntitySetRights.All);
            configuration.DataServiceBehavior.MaxProtocolVersion = System.Data.Services.Common.DataServiceProtocolVersion.V2;
        }
    }
}