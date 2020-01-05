using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_Users.Api.Models.UserLog
{
    public class UserLogModel
    {
        public DateTime Created { get; set; }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public bool? IsActive { get; set; }
    }
}
