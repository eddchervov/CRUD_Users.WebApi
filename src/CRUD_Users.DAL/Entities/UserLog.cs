using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CRUD_Users.DAL.Entities
{
    public class UserLog
    {
        [Key]
        public long Id { get; set; }
        public DateTime Created { get; set; }

        public long UserId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public bool? IsActive { get; set; }
    }
}
