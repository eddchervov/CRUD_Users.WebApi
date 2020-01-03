using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_Users.Api.Models.User
{
    public class UserModel
    {
        public long Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        public string FullName
        {
            get
            {
                return $"{LastName} {FirstName} {MiddleName}".Trim();
            }
        }

        public string Initial
        {
            get
            {
                string firstNameInitial = $" {FirstName[0]}.";
                string patronymicInitial = string.IsNullOrEmpty(MiddleName) ? "" : $" {MiddleName[0]}.";
                return LastName + firstNameInitial + patronymicInitial;
            }
        }

        public bool IsActive { get; set; }

        public DateTime ChangedDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
