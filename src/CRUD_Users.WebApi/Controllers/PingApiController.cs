using CRUD_Users.Api.Models.Ping;
using CRUD_Users.DAL.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Diagnostics;
using System.Linq;

namespace CRUD_Users.WebApi.Controllers
{
    public class PingApiController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _configuration;

        public PingApiController(IUserRepository userRepository,
            IConfiguration configuration)
        {
            _userRepository = userRepository;
            _configuration = configuration;
        }

        [HttpGet]
        [Route("api/ping/get-db")]
        public GetPingApiResponse Get()
        {
            var ret = new GetPingApiResponse();

            var watch = new Stopwatch();
            watch.Start();
            var tt = _userRepository.GetById(0);
            watch.Stop();
            ret.Services.Add(new GetPingApiServiceModel { Service = "APPDB", Milisecconds = watch.ElapsedMilliseconds });

            watch = new Stopwatch();
            watch.Start();
            var val = _configuration["test-emtpy"];
            watch.Stop();
            ret.Services.Add(new GetPingApiServiceModel { Service = "Configuration", Milisecconds = watch.ElapsedMilliseconds });

            ret.TotalMiliseconds = ret.Services.Sum(x => x.Milisecconds);

            return ret;
        }

        [HttpGet]
        [Route("api/ping/date")]
        public DateTime GetDate()
        {
            return DateTime.Now;
        }
    }
}
