using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_Users.Api.Models.User
{
    public class CreateUserResponse : BaseResponse
    {
        public UserModel User { get; set; }
    }
}
