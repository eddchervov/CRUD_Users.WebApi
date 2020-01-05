using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CRUD_Users.Api.Models.User
{
    public class GetUsersRequest
    {
        public bool IsActive { get; set; } = true;

        [Range(0, int.MaxValue)]
        public int SkipCount { get; set; }

        [Range(1, int.MaxValue)]
        public int TakeCount { get; set; }
    }
}
