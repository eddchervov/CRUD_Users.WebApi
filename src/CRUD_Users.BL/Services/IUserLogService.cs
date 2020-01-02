using CRUD_Users.Api.Models.UserLog;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Users.BL.Services
{
    public interface IUserLogService
    {
        Task<GetUserLogsResponse> GetAsync(GetUserLogRequest request);
    }
}
