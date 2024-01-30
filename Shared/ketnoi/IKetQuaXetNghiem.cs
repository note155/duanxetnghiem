using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using duanxetnghiem.Data.Model;

namespace Shared.ketnoi
{
    public interface IKetQuaXetNghiem
    {
        Task<KetQuaXetNghiem> addAsync(KetQuaXetNghiem KetQuaXetNghiem);
        Task<KetQuaXetNghiem> updateAsync(KetQuaXetNghiem KetQuaXetNghiem);
        Task<KetQuaXetNghiem> deleteAsync(int id);
        Task<List<KetQuaXetNghiem>> getallAsync();
        Task<KetQuaXetNghiem> getbyid(int Id);
    }
}
