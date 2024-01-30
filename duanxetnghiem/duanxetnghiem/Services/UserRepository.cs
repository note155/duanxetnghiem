using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using duanxetnghiem.Data;
using duanxetnghiem.Data.Model;
using Microsoft.EntityFrameworkCore;
using Shared.ketnoi;

namespace duanxetnghiem.Services
{
    public class UserRepository : IUser
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<User> adduserAsync(User user)
        {
            if (user == null) return null;
            Console.WriteLine(user.Diachi);
            var newstudent = _context.Users.Add(user).Entity;
            await _context.SaveChangesAsync();

            return newstudent;
        }

        public async Task<User> deleteuserAsync(int id)
        {
            var user = await _context.Users.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (user == null) return null;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<List<User>> getalluserAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> getuserbyid(int Id)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Id == Id);
        }

        public async Task<User> updateuserAsync(User updatedUser)
        {

            if (updatedUser == null) return null;

            var updateuser = _context.Users.Update(updatedUser).Entity;

            await _context.SaveChangesAsync();

            return updateuser;
        }
    }
}
