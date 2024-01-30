using duanxetnghiem.Data.Model;
using System.Net.Http.Json;

namespace duanxetnghiem.Client.Services
{
    public class BacSiServices
    {
        private readonly HttpClient _httpClient;
        public BacSiServices(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<BacSi> addAsync(BacSi user)
        {
            var newstudent = await _httpClient.PostAsJsonAsync("api/BacSi/Add-BacSi", user);
            var respone = await newstudent.Content.ReadFromJsonAsync<BacSi>();
            return respone;
        }

        public async Task<BacSi> deleteuserAsync(int id)
        {
            var newstudent = await _httpClient.PostAsJsonAsync("api/BacSi/Delete-BacSi", id);
            var respone = await newstudent.Content.ReadFromJsonAsync<BacSi>();
            return respone;
        }

        public async Task<List<BacSi>> getalluserAsync()
        {
            var allstudent = await _httpClient.GetAsync("api/BacSi/All-BacSi");
            var respone = await allstudent.Content.ReadFromJsonAsync<List<BacSi>>();
            return respone;
        }

        public async Task<BacSi> getuserbyid(int Id)
        {
            var onestudent = await _httpClient.GetAsync("api/BacSi/Single-BacSi");
            var respone = await onestudent.Content.ReadFromJsonAsync<BacSi>();
            return respone;
        }

        public async Task<BacSi> updateuserAsync(BacSi User)
        {
            var newstudent = await _httpClient.PostAsJsonAsync("api/BacSi/Update-BacSi", User);
            var respone = await newstudent.Content.ReadFromJsonAsync<BacSi>();
            return respone;
        }
    }

}
