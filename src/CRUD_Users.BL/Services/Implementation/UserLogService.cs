using CRUD_Users.Api.Models.UserLog;
using CRUD_Users.DAL.Entities;
using CRUD_Users.DAL.Repositories;
using System.Linq;
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
            var resposne = new GetUserLogsResponse();

            var userLogs = await _userLogRepository.GetByUserIdAsync(request.UserId);
            resposne.UserLogModels = userLogs.Select(ConvertModel).ToList();

            return resposne;
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
