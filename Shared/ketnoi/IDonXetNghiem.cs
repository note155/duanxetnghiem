using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using duanxetnghiem.Data.Model;

namespace Shared.ketnoi
{
    public interface IDonXetNghiem
    {
        Task<DonXetNghiem> addAsync(DonXetNghiem DonXetNghiem);
        Task<DonXetNghiem> updateAsync(DonXetNghiem DonXetNghiem);
        Task<DonXetNghiem> deleteAsync(int id);
        Task<List<DonXetNghiem>> getallAsync();
        Task<DonXetNghiem> getbyid(int Id);
    }
}
