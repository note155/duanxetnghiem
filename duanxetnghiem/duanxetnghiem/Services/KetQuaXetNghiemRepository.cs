using duanxetnghiem.Data;
using duanxetnghiem.Data.Model;
using Microsoft.EntityFrameworkCore;
using Shared.ketnoi;

namespace duanxetnghiem.Services
{
    public class KetQuaXetNghiemRepository :IKetQuaXetNghiem
    {
        private readonly ApplicationDbContext _context;

        public KetQuaXetNghiemRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<KetQuaXetNghiem> addAsync(KetQuaXetNghiem KetQuaXetNghiem)
        {
            if (KetQuaXetNghiem == null) return null;
            var newstudent = _context.KetQuaXetNghiems.Add(KetQuaXetNghiem).Entity;
            await _context.SaveChangesAsync();

            return newstudent;
        }

        public async Task<KetQuaXetNghiem> deleteAsync(int id)
        {
            var ketQuaXetNghiemToDelete = await _context.KetQuaXetNghiems.FindAsync(id);
            if (ketQuaXetNghiemToDelete != null)
            {
                _context.KetQuaXetNghiems.Remove(ketQuaXetNghiemToDelete);
                await _context.SaveChangesAsync();
                return ketQuaXetNghiemToDelete;
            }
            return null;
        }

        public async Task<List<KetQuaXetNghiem>> getallAsync()
        {
            return await _context.KetQuaXetNghiems.ToListAsync();
        }

        public async Task<KetQuaXetNghiem> getbyid(int Id)
        {
            return await _context.KetQuaXetNghiems.FindAsync(Id);
        }

        public async Task<KetQuaXetNghiem> updateAsync(KetQuaXetNghiem ketQuaXetNghiem)
        {
            if (ketQuaXetNghiem == null) return null;

            var updateKetQuaXetNghiem = _context.KetQuaXetNghiems.Update(ketQuaXetNghiem).Entity;

            await _context.SaveChangesAsync();

            return updateKetQuaXetNghiem;
        }
    }
}
