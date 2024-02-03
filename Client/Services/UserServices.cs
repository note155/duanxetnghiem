using System.Net.Http.Json;
using Blazored.LocalStorage;
using duanxetnghiem.Data.Model;
using Shared.form;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Client.Services
{
    public class UserServices : IUser
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorageService;
        public UserServices(HttpClient httpClient,
            ILocalStorageService localStorageService)
        {
            this._httpClient = httpClient;
            _localStorageService = localStorageService;
        }
        public async Task<int> adduserAsync(User user)
        {
            var newstudent = await _httpClient.PostAsJsonAsync("api/Studen/Add-User", user);
            var respone = await newstudent.Content.ReadFromJsonAsync<int>();
            return respone;
        }
        public async Task<bool> dangky(acc acc)
        {
            var newstudent = await _httpClient.PostAsJsonAsync("api/Studen/dangky", acc);
            var respone = await newstudent.Content.ReadFromJsonAsync<bool>();
            return respone;
        }

        public async Task<User> deleteuserAsync(int id)
        {
            var newstudent = await _httpClient.PostAsJsonAsync("api/Studen/Delete-User", id);
            var respone = await newstudent.Content.ReadFromJsonAsync<User>();
            return respone;
        }

        public async Task<List<User>> getalluserAsync()
        {
            var allstudent = await _httpClient.GetAsync("api/Studen/All-User");
            var respone = await allstudent.Content.ReadFromJsonAsync<List<User>>();
            return respone;
        }

        public async Task<User> getuserbyid(int Id)
        {
            var onestudent = await _httpClient.GetAsync("api/Studen/Single-User");
            var respone = await onestudent.Content.ReadFromJsonAsync<User>();
            return respone;
        }

        public async Task<int> IsUserExistsAsync(User user)
        {
            var allstudent = await _httpClient.PostAsJsonAsync("api/Studen/EmailExists", user);
            var respone = await allstudent.Content.ReadFromJsonAsync<int>();
            return respone;
        }

        public async Task<bool> login(loginform user)
        {
            var allstudent = await _httpClient.PostAsJsonAsync("api/Studen/login",user);
            var respone = await allstudent.Content.ReadFromJsonAsync<bool>();
            if (respone)
            {
                await _localStorageService.SetItemAsync("email", user.Email);

            }
            return respone;
        }

        public async Task<User> updateuserAsync(User User)
        {
            var newstudent = await _httpClient.PostAsJsonAsync("api/Studen/Update-User", User);
            var respone = await newstudent.Content.ReadFromJsonAsync<User>();
            return respone;
        }
    }
}
