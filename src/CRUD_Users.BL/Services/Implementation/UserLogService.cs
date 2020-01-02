using CRUD_Users.Api.Models.UserLog;
using CRUD_Users.DAL.Entities;
using CRUD_Users.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Users.BL.Services.Implementation
{
    internal class UserLogService : IUserLogService
    {
        private readonly IUserLogRepository _userLogRepository;

        public UserLogService(IUserLogRepository userLogRepository)
        {
            _userLogRepository = userLogRepository;
        }

        public async Task<GetUserLogsResponse> GetAsync(GetUserLogRequest request)
        {
            var userLogs = await _userLogRepository.GetByUserId(request.UserId);

            return new GetUserLogsResponse
            {
                UserLogModels = userLogs.Select(ConvertModel).ToList()
            };
        }

        #region private
        private UserLogModel ConvertModel(UserLog userLog)
        {
            return new UserLogModel
            {
                Id = userLog.Id,
                Created = userLog.Created,
                LastName = userLog.LastName,
                FirstName = userLog.FirstName,
                MiddleName = userLog.MiddleName,
                IsActive = userLog.IsActive
            };
        }
        #endregion
    }
}
