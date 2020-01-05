using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_Users.Api.Models
{
    public class BaseResponse
    {
        public bool IsSuccess { get; set; } = true;
        public string Message { get; set; } = string.Empty;
    }
}
