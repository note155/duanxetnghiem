using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Shared.Model;
using Shared.form;
using Shared.Model;
using duanxetnghiem.Data;
using System;
using Shared.ketnoi;
namespace duanxetnghiem.Services
{
    public class AccRepository : Iaccount
    {
        private readonly ApplicationDbContext _context;

        public AccRepository(ApplicationDbContext context)
        {
            _context = context;
        }



        public async Task<acc> Login(loginform uss)
        {

            var user = await _context.accs.FirstOrDefaultAsync(x => x.Email == uss.Email);

            if (user != null)
            {
                bool isPasswordCorrect = BCrypt.Net.BCrypt.Verify(uss.Password, user.pass);

                if (isPasswordCorrect)
                {
                    return user; // Login successful
                }
            }

            return null;
        }

        public Task<acc> Logout()
        {
            throw new NotImplementedException();
        }
    }
}