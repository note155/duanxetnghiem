using duanxetnghiem.Data;
using duanxetnghiem.Data.Model;
using Microsoft.EntityFrameworkCore;
using Shared.form;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Services
{
    public class UserRepository : IUser
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> adduserAsync(User user)
        {
            if (user == null) return -1; // hoặc giá trị đặc biệt để biểu thị lỗi

            var newuser = _context.Users.Add(user).Entity;
            await _context.SaveChangesAsync();

            return newuser.Id;
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
        public async Task<int> IsUserExistsAsync(User user)
        {
            if (user == null) return -1;

            var existingUser = await _context.Users.FirstOrDefaultAsync(x =>
                x.Email == user.Email
                && x.Hoten == user.Hoten
                && x.SDT == user.SDT
                && x.Diachi == user.Diachi
                && x.Tuoi == user.Tuoi
            );

            return existingUser?.Id ?? -1;
        }

        public async Task<bool> login(loginform uss)
        {
            if (string.IsNullOrEmpty(uss.Email) || string.IsNullOrEmpty(uss.Password))
            {
                return false; // Invalid input
            }
            var user = await _context.accs.FirstOrDefaultAsync(x => x.Email == uss.Email);

            if (user != null)
            {
                bool isPasswordCorrect = BCrypt.Net.BCrypt.Verify(uss.Password, user.pass);

                if (isPasswordCorrect)
                {
                    return true; // Login successful
                }
            }

            return false; // Login failed
        }

        public async Task<bool> dangky(acc acc)
        {
            if (acc == null) return false; 
            string pass= BCrypt.Net.BCrypt.HashPassword(acc.pass);
            acc.pass=pass;
            var newuser = _context.accs.Add(acc).Entity;
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
