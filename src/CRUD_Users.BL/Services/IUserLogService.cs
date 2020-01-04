using CRUD_Users.Api.Models.UserLog;
using System.Threading.Tasks;

namespace CRUD_Users.BL.Services
{
    public interface IUserLogService
    {
        Task<GetUserLogsResponse> GetAsync(GetUserLogRequest request);
    }
}
