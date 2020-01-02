using System;
using System.Collections.Generic;
using System.Text;
using CRUD_Users.DAL.Entities;

namespace CRUD_Users.DAL.Models.Users
{
    public class GetUsersDalResponse
    {
        public int TotalCount { get; set; }
        public List<User> Users { get; set; }
    }
}
