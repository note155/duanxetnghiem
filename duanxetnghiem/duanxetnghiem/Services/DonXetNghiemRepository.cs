using duanxetnghiem.Data;
using duanxetnghiem.Data.Model;
using Microsoft.EntityFrameworkCore;
using Shared.ketnoi;

namespace duanxetnghiem.Services
{
    public class DonXetNghiemRepository : IDonXetNghiem
    {
        private readonly ApplicationDbContext _context;

        public DonXetNghiemRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<DonXetNghiem> addAsync(DonXetNghiem donXetNghiem)
        {
            if (donXetNghiem == null) return null;
            var newstudent = _context.DonXetNghiems.Add(donXetNghiem).Entity;
            await _context.SaveChangesAsync();

            return newstudent;
        }

        public async Task<DonXetNghiem> deleteAsync(int id)
        {
            var donXetNghiemToDelete = await _context.DonXetNghiems.FindAsync(id);
            if (donXetNghiemToDelete != null)
            {
                _context.DonXetNghiems.Remove(donXetNghiemToDelete);
                await _context.SaveChangesAsync();
                return donXetNghiemToDelete;
            }
            return null;
        }

        public async Task<List<DonXetNghiem>> getallAsync()
        {
            return await _context.DonXetNghiems.ToListAsync();
        }

        public async Task<DonXetNghiem> getbyid(int Id)
        {
            return await _context.DonXetNghiems.FindAsync(Id);
        }

        public async Task<DonXetNghiem> updateAsync(DonXetNghiem donXetNghiem)
        {
            if (donXetNghiem == null) return null;

            var updateDonXetNghiem = _context.DonXetNghiems.Update(donXetNghiem).Entity;

            await _context.SaveChangesAsync();

            return updateDonXetNghiem;
        }
    }
}
