﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_Users.Api.Models.User
{
    public class UpdateUserResponse : BaseResponse
    {
        public UserModel User { get; set; }
    }
}
