using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_Users.Api.Models.UserLog
{
    public class GetUserLogsResponse
    {
        public List<UserLogModel> UserLogModels { get; set; } = new List<UserLogModel>();
    }
}
