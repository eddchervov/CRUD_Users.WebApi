using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_Users.Api.Models.Ping
{
    public class GetPingApiServiceModel
    {
        public string Service { get; set; }
        public long Milisecconds { get; set; }
    }
}
