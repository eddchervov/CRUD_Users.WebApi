using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_Users.Api.Models.User
{
    public class GetUsersResponse : BaseResponse
    {
        public int TotalCount { get; set; }
        public List<UserModel> Users { get; set; } = new List<UserModel>();
    }
}
