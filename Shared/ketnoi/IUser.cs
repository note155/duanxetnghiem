using duanxetnghiem.Data.Model;
using Shared.form;
using Shared.Model;

namespace Shared.ketnoi
{
    public interface IUser
    {
        Task<int> adduserAsync(User user);
        Task<User> updateuserAsync(User User);
        Task<User> deleteuserAsync(int id);
        Task<List<User>> getalluserAsync();
        Task<User> getuserbyid(int Id);
        Task<int> IsUserExistsAsync(User user);
        Task<bool> login(loginform user);
        Task<bool> dangky(acc acc);
    }
}
