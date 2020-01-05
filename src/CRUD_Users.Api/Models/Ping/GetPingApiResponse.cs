using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_Users.Api.Models.Ping
{
    public class GetPingApiResponse
    {
        public long TotalMiliseconds { get; set; }
        public List<GetPingApiServiceModel> Services { get; set; } = new List<GetPingApiServiceModel>();
    }
}
