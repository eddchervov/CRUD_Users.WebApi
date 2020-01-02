using CRUD_Users.Api.Models.User;
using Goober.Core.Services;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace CRUD_Users.Api.Services.Implementation
{
    internal class UserRemoteCallService : BaseRemoteCallService, IUserRemoteCallService
    {
        public UserRemoteCallService(ICacheProvider cacheProvider, IConfiguration configuration)
            : base(cacheProvider, configuration)
        { }

        protected override string _apiSchemeAndHostConfigKey { get; set; } = "CRUD_Users.Api.SchemeAndHost";

        public async Task<GetUsersResponse> GetAsync(GetUsersRequest request)
            => await ExecutePostAsync<GetUsersResponse, GetUsersRequest>("/api/users/get", request);

        public async Task<CreateUserResponse> CreateAsync(CreateUserRequest request)
            => await ExecutePostAsync<CreateUserResponse, CreateUserRequest>("/api/users/create", request);

        public async Task<UpdateUserResponse> UpdateAsync(UpdateUserRequest request)
            => await ExecutePostAsync<UpdateUserResponse, UpdateUserRequest>("/api/users/update", request);
    }
}
