using CRUD_Users.DAL.DBContext;
using CRUD_Users.DAL.Entities;
using CRUD_Users.DAL.Models.Users;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Users.DAL.Repositories.Implementation
{
    internal class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly IAppDBContext _context;

        public UserRepository(IAppDBContext context)
            : base(context.Users)
        {
            _context = context;
        }

        public async Task<GetUsersDalResponse> GetAsync(GetUsersDalRequest request)
        {
            var query = from u in _context.Users
                        where u.IsActive == request.IsActive
                        select new User
                        {
                            Id = u.Id,
                            LastName = u.LastName,
                            FirstName = u.FirstName,
                            MiddleName = u.MiddleName,
                            ChangedDate = u.ChangedDate,
                            CreatedDate = u.CreatedDate,
                            IsActive = u.IsActive
                        };

            var totalCount = await query.CountAsync();

            query = query.Skip(request.SkipCount).Take(request.TakeCount);

            return new GetUsersDalResponse
            {
                TotalCount = totalCount,
                Users = await query.ToListAsync()
            };
        }

        public async Task<User> GetByIdAsync(long id)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
