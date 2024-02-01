using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using duanxetnghiem.Data.Model;

namespace Shared.ketnoi
{
    public interface IUser
    {
        Task<int> adduserAsync(User user);
        Task<User> updateuserAsync(User User);
        Task<User> deleteuserAsync(int id);
        Task<List<User>> getalluserAsync();
        Task<User> getuserbyid(int Id);
        Task<bool> IsEmailExistsAsync(string email);
        Task<int> getidbyemail(string email);
    }
}
