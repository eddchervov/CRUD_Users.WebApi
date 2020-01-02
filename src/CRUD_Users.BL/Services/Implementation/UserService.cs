using CRUD_Users.Api.Models.User;
using CRUD_Users.DAL.Entities;
using CRUD_Users.DAL.Models.Users;
using CRUD_Users.DAL.Repositories;
using Goober.Core.Extensions;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Users.BL.Services.Implementation
{
    internal class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserLogRepository _userLogRepository;

        public UserService(IUserRepository userRepository,
            IUserLogRepository userLogRepository)
        {
            _userRepository = userRepository;
            _userLogRepository = userLogRepository;
        }

        public async Task<GetUsersResponse> GetAsync(GetUsersRequest request)
        {
            var response = await _userRepository.GetAsync(new GetUsersDalRequest
            {
                SkipCount = request.SkipCount,
                TakeCount = request.TakeCount,
                IsActive = request.IsActive
            });

            return new GetUsersResponse
            {
                TotalCount = response.TotalCount,
                Users = response.Users.Select(ConvertModel).ToList()
            };
        }

        public async Task<CreateUserResponse> CreateAsync(CreateUserRequest request)
        {
            var user = ConvertModel(request);
            await _userRepository.InsertAsync(user);

            var userLog = CreateUserLog(user);
            await _userLogRepository.InsertAsync(userLog);

            return new CreateUserResponse { UserId = user.Id };
        }

        public async Task<UpdateUserResponse> UpdateAsync(UpdateUserRequest request)
        {
            var user = await _userRepository.GetByIdAsync(request.Id);
            user.RequiredNotNull("User is null, id=" + request.Id);

            var tupleUpdate = UpdateModel(ref user, request);

            if (tupleUpdate.isUpdate)
            {
                await _userRepository.UpdateAsync(user);
                await _userLogRepository.InsertAsync(tupleUpdate.userLog);
            }

            return new UpdateUserResponse { IsUpdate = tupleUpdate.isUpdate };
        }

        #region private
        private (bool isUpdate, UserLog userLog) UpdateModel(ref User user, UpdateUserRequest userRequest)
        {
            var isUpdate = false;

            var userLog = new UserLog
            {
                Created = DateTime.Now,

                UserId = user.Id
            };

            if (user.LastName != userRequest.LastName)
            {
                user.LastName = userRequest.LastName;
                userLog.LastName = userRequest.LastName;
                isUpdate = true;
            }
            if (user.FirstName != userRequest.FirstName)
            {
                user.FirstName = userRequest.FirstName;
                userLog.FirstName = userRequest.FirstName;
                isUpdate = true;
            }
            if (user.MiddleName != userRequest.MiddleName)
            {
                user.MiddleName = userRequest.MiddleName;
                userLog.MiddleName = userRequest.MiddleName;
                isUpdate = true;
            }
            if (user.IsActive != userRequest.IsActive)
            {
                user.IsActive = userRequest.IsActive;
                userLog.IsActive = userRequest.IsActive;
                isUpdate = true;
            }

            if (isUpdate) user.ChangedDate = DateTime.Now;

            return (isUpdate, userLog);
        }

        private User ConvertModel(CreateUserRequest request)
        {
            return new User
            {
                LastName = request.LastName,
                FirstName = request.FirstName,
                MiddleName = request.MiddleName,
                IsActive = true,
                CreatedDate = DateTime.Now,
                ChangedDate = DateTime.Now
            };
        }

        private UserModel ConvertModel(User user)
        {
            return new UserModel
            {
                Id = user.Id,
                LastName = user.LastName,
                FirstName = user.FirstName,
                MiddleName = user.MiddleName,
                IsActive = user.IsActive,
                CreatedDate = user.CreatedDate,
                ChangedDate = user.ChangedDate
            };
        }

        private UserLog CreateUserLog(User user)
        {
            return new UserLog
            {
                Created = DateTime.Now,

                UserId = user.Id,
                LastName = user.LastName,
                FirstName = user.FirstName,
                MiddleName = user.MiddleName,
                IsActive = user.IsActive
            };
        }
        #endregion
    }
}
