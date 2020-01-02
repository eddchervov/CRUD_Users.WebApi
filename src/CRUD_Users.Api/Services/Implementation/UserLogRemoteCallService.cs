using CRUD_Users.Api.Models.UserLog;
using Goober.Core.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Users.Api.Services.Implementation
{
    internal class UserLogRemoteCallService : BaseRemoteCallService, IUserLogRemoteCallService
    {
        public UserLogRemoteCallService(ICacheProvider cacheProvider, IConfiguration configuration)
            : base(cacheProvider, configuration)
        { }

        protected override string _apiSchemeAndHostConfigKey { get; set; } = "CRUD_Users.Api.SchemeAndHost";

        public async Task<GetUserLogsResponse> GetAsync(GetUserLogRequest request)
            => await ExecutePostAsync<GetUserLogsResponse, GetUserLogRequest>("/api/user-logs/get-by-user-id", request);
    }
}
