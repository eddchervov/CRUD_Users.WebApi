using CRUD_Users.Api.Models.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Users.BL.Services
{
    public interface IUserService
    {
        Task<GetUsersResponse> GetAsync(GetUsersRequest request);
        Task<CreateUserResponse> CreateAsync(CreateUserRequest request);
        Task<UpdateUserResponse> UpdateAsync(UpdateUserRequest request);
    }
}
