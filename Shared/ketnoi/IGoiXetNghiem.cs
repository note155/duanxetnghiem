using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using duanxetnghiem.Data.Model;

namespace Shared.ketnoi
{
    public interface IGoiXetNghiem
    {
        Task<GoiXetNghiem> addAsync(GoiXetNghiem GoiXetNghiem);
        Task<GoiXetNghiem> updateAsync(GoiXetNghiem GoiXetNghiem);
        Task<GoiXetNghiem> deleteAsync(int id);
        Task<List<GoiXetNghiem>> getallAsync();
        Task<GoiXetNghiem> getbyid(int Id);
    }
}
