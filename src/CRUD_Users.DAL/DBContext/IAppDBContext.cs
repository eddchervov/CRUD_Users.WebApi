using CRUD_Users.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Users.DAL.DBContext
{
    public interface IAppDBContext : IBaseDbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<UserLog> UserLogs { get; set; }
    }
}
