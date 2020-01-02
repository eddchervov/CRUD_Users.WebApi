using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_Users.DAL.Models.Users
{
    public class GetUsersDalRequest
    {
        public bool IsActive { get; set; }
        public int SkipCount { get; set; }
        public int TakeCount { get; set; }
    }
}
