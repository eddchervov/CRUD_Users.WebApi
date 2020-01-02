using CRUD_Users.DAL.Entities;
using CRUD_Users.DAL.Models.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Users.DAL.Repositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<GetUsersDalResponse> GetAsync(GetUsersDalRequest request);
        Task<User> GetByIdAsync(long id);
    }
}