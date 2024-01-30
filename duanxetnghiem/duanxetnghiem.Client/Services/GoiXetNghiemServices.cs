using duanxetnghiem.Data.Model;
using Shared.ketnoi;
using System.Net.Http.Json;

namespace duanxetnghiem.Client.Services
{
    public class GoiXetNghiemServices :IGoiXetNghiem
    {
        private readonly HttpClient _httpClient;
        public GoiXetNghiemServices(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<GoiXetNghiem> addAsync(GoiXetNghiem user)
        {
            var newstudent = await _httpClient.PostAsJsonAsync("api/GXN/Add-GXN", user);
            var respone = await newstudent.Content.ReadFromJsonAsync<GoiXetNghiem>();
            return respone;
        }

        public async Task<GoiXetNghiem> deleteAsync(int id)
        {
            var newstudent = await _httpClient.PostAsJsonAsync("api/GXN/Delete-GXN", id);
            var respone = await newstudent.Content.ReadFromJsonAsync<GoiXetNghiem>();
            return respone;
        }

        public async Task<List<GoiXetNghiem>> getallAsync()
        {
            var allstudent = await _httpClient.GetAsync("api/GXN/All-GXN");
            var respone = await allstudent.Content.ReadFromJsonAsync<List<GoiXetNghiem>>();
            return respone;
        }

        public async Task<GoiXetNghiem> getbyid(int Id)
        {
            var onestudent = await _httpClient.GetAsync("api/GXN/Single-GXN");
            var respone = await onestudent.Content.ReadFromJsonAsync<GoiXetNghiem>();
            return respone;
        }

        public async Task<GoiXetNghiem> updateAsync(GoiXetNghiem User)
        {
            var newstudent = await _httpClient.PostAsJsonAsync("api/GXN/Update-GXN", User);
            var respone = await newstudent.Content.ReadFromJsonAsync<GoiXetNghiem>();
            return respone;
        }
    }
}
