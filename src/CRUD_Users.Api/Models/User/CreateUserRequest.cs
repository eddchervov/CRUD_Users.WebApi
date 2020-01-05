using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CRUD_Users.Api.Models.User
{
    public class CreateUserRequest
    {
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }
    }
}
