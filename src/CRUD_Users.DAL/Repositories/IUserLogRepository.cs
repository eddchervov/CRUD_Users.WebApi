using CRUD_Users.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Users.DAL.Repositories
{
    public interface IUserLogRepository : IBaseRepository<UserLog>
    {
        Task<List<UserLog>> GetByUserId(long userId);
    }
}
