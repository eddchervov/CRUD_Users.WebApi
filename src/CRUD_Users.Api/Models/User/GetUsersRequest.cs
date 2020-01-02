using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_Users.Api.Models.User
{
    public class GetUsersRequest
    {
        public bool IsActive { get; set; } = true;
        public int SkipCount { get; set; }
        public int TakeCount { get; set; }
    }
}
