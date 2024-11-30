﻿using AutoTurn.Application.Interfaces.Repository;
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

        public async  Task<User?> GetUserByUserNameAsync(string userName)
        {
          return await _context.Users.SingleOrDefaultAsync(u => u.UserName == userName);
        }
    }
}