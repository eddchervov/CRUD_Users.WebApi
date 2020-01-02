using CRUD_Users.Api.Models.User;
using CRUD_Users.BL.Services;
using Goober.Core.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CRUD_Users.WebApi.Controllers
{
    [Route("api/users")]
    public class UserApiController : Controller
    {
        private readonly IUserService _userService;
        public UserApiController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("get")]
        public async Task<GetUsersResponse> GetAsync([FromBody]GetUsersRequest request)
        {
            request.RequiredNotNull("GetRequest is null");

            return await _userService.GetAsync(request);
        }

        [HttpPost("create")]
        public async Task<CreateUserResponse> CreateAsync([FromBody]CreateUserRequest request)
        {
            request.RequiredNotNull("CreateRequest is null");

            return await _userService.CreateAsync(request);
        }

        [HttpPost("update")]
        public async Task<UpdateUserResponse> UpdateAsync([FromBody]UpdateUserRequest request)
        {
            request.RequiredNotNull("UpdateRequest is null");

            return await _userService.UpdateAsync(request);
        }
    }
}
