using duanxetnghiem.Data;
using duanxetnghiem.Data.Model;
using Microsoft.EntityFrameworkCore;
using Shared.ketnoi;

namespace duanxetnghiem.Services
{
    public class BacSiRepository : IBacSi
    {
        private readonly ApplicationDbContext _context;

        public BacSiRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<BacSi> addAsync(BacSi bacsi)
        {
            if (bacsi == null) return null;
            var newstudent = _context.BacSis.Add(bacsi).Entity;
            await _context.SaveChangesAsync();

            return newstudent;
        }

        public async Task<BacSi> deleteAsync(int id)
        {
            var bacsiToDelete = await _context.BacSis.FindAsync(id);
            if (bacsiToDelete != null)
            {
                _context.BacSis.Remove(bacsiToDelete);
                await _context.SaveChangesAsync();
                return bacsiToDelete;
            }
            return null;
        }

        public async Task<List<BacSi>> getallAsync()
        {
            return await _context.BacSis.ToListAsync();
        }

        public async Task<BacSi> getbyid(int Id)
        {
            return await _context.BacSis.FindAsync(Id);
        }

        public async Task<BacSi> updateAsync(BacSi bacsi)
        {
            if (bacsi == null) return null;

            var updateuser = _context.BacSis.Update(bacsi).Entity;

            await _context.SaveChangesAsync();

            return updateuser;
        }
    }
}
