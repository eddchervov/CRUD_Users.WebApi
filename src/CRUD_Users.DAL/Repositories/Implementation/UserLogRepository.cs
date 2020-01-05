using CRUD_Users.DAL.DBContext;
using CRUD_Users.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Users.DAL.Repositories.Implementation
{
    internal class UserLogRepository : BaseRepository<UserLog>, IUserLogRepository
    {
        private readonly IAppDBContext _context;

        public UserLogRepository(IAppDBContext context)
            : base(context.UserLogs)
        {
            _context = context;
        }

        public async Task<List<UserLog>> GetByUserIdAsync(long userId)
        {
            return await _context.UserLogs.Where(x => x.UserId == userId).ToListAsync();
        }
    }
}
