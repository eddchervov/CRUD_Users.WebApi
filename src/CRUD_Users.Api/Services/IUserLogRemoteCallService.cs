using CRUD_Users.Api.Models.UserLog;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Users.Api.Services
{
    public interface IUserLogRemoteCallService
    {
        Task<GetUserLogsResponse> GetAsync(GetUserLogRequest request);
    }
}
