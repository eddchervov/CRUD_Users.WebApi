﻿using CRUD_Users.Api.Models.User;
using System.Threading.Tasks;

namespace CRUD_Users.Api.Services
{
    public interface IUserRemoteCallService
    {
        Task<GetUsersResponse> GetAsync(GetUsersRequest request);
        Task<CreateUserResponse> CreateAsync(CreateUserRequest request);
        Task<UpdateUserResponse> UpdateAsync(UpdateUserRequest request);
    }
}
