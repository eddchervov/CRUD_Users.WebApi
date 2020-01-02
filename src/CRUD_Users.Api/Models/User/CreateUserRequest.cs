using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_Users.Api.Models.User
{
    public class CreateUserRequest
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
    }
}
