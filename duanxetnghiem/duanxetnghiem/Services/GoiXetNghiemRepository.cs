using duanxetnghiem.Data;
using duanxetnghiem.Data.Model;
using Microsoft.EntityFrameworkCore;
using Shared.ketnoi;

namespace duanxetnghiem.Services
{
    public class GoiXetNghiemRepository :IGoiXetNghiem
    {
        private readonly ApplicationDbContext _context;

        public GoiXetNghiemRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<GoiXetNghiem> addAsync(GoiXetNghiem GoiXetNghiem)
        {
            if (GoiXetNghiem == null) return null;
            var newstudent = _context.GoiXetNghiems.Add(GoiXetNghiem).Entity;
            await _context.SaveChangesAsync();

            return newstudent;
        }

        public async Task<GoiXetNghiem> deleteAsync(int id)
        {
            var goiXetNghiemToDelete = await _context.GoiXetNghiems.FindAsync(id);
            if (goiXetNghiemToDelete != null)
            {
                _context.GoiXetNghiems.Remove(goiXetNghiemToDelete);
                await _context.SaveChangesAsync();
                return goiXetNghiemToDelete;
            }
            return null;
        }

        public async Task<List<GoiXetNghiem>> getallAsync()
        {
            return await _context.GoiXetNghiems.ToListAsync();
        }

        public async Task<GoiXetNghiem> getbyid(int Id)
        {
            return await _context.GoiXetNghiems.FindAsync(Id);
        }

        public async Task<GoiXetNghiem> updateAsync(GoiXetNghiem GoiXetNghiem)
        {
            if (GoiXetNghiem == null) return null;

            var updateGoiXetNghiem = _context.GoiXetNghiems.Update(GoiXetNghiem).Entity;

            await _context.SaveChangesAsync();

            return updateGoiXetNghiem;
        }
    }
}
