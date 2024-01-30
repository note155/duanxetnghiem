using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using duanxetnghiem.Data.Model;

namespace Shared.ketnoi
{
    public interface IBacSi
    {
        Task<BacSi> addAsync(BacSi bacsi);
        Task<BacSi> updateAsync(BacSi bacsi);
        Task<BacSi> deleteAsync(int id);
        Task<List<BacSi>> getallAsync();
        Task<BacSi> getbyid(int Id);
    }
}
