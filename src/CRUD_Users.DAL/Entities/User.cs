using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CRUD_Users.DAL.Entities
{
    public class User
    {
        [Key]
        public long Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        public bool IsActive { get; set; }

        public DateTime ChangedDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
