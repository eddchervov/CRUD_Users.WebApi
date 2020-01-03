using CRUD_Users.Api.Models.UserLog;
using CRUD_Users.BL.Services;
using CRUD_Users.Utils.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CRUD_Users.WebApi.Controllers
{
    [ApiController]
    [Route("api/user-logs")]
    public class UserLogApiController : ControllerBase
    {
        private readonly IUserLogService _userLogService;

        public UserLogApiController(IUserLogService userLogService)
        {
            _userLogService = userLogService;
        }

        [HttpPost("get-by-user-id")]
        public async Task<GetUserLogsResponse> GetAsync([FromBody]GetUserLogRequest request)
        {
            request.RequiredNotNull("GetRequest", "object is null");

            return await _userLogService.GetAsync(request);
        }
    }
}
