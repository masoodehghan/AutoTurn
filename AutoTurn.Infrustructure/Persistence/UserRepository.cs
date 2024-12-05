using AutoTurn.Application.Interfaces.Repository;
using AutoTurn.Models;
using Microsoft.EntityFrameworkCore;


namespace AutoTurn.Infrustructure.Persistence
{
    public class UserRepository : IUserRepository
    {
        private readonly AutoTurnDbContext _context;

        public UserRepository(AutoTurnDbContext context)
        {
            _context = context;
        }

        public User GetUseByUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public async Task<User?> GetUserByIdAsync(string id)
        {
            return await _context.Users.SingleOrDefaultAsync(u => u.Id == id);

        }

        public async Task<User?> GetUserByIdWithOfficeAsync(string Id)
        {
            return await _context.Users.Include(f => f.Office)
                .AsNoTracking().SingleOrDefaultAsync(f => f.Id == Id);
        }

        public async Task<User?> GetUserByIdWithPlanAsync(string Id)
        {
            return await _context.Users
                .Include(f => f.Office).ThenInclude(s => s.Plans)
                .SingleOrDefaultAsync(f => f.Id == Id);
        }

        public async Task<User?> GetUserByIdWithProvinceAsync(string Id)
        {
            return await _context.Users.Include(s => s.Province)
                .SingleOrDefaultAsync(u => u.Id == Id);
        }



        public async  Task<User?> GetUserByUserNameAsync(string userName)
        {
            return await _context.Users.FirstOrDefaultAsync(o => o.UserName == userName);
        }
    }
}
