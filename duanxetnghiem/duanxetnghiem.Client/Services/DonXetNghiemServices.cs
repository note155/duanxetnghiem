using duanxetnghiem.Data.Model;
using Shared.ketnoi;
using System.Net.Http.Json;

namespace duanxetnghiem.Client.Services
{
    public class DonXetNghiemServices :IDonXetNghiem
    {
        private readonly HttpClient _httpClient;
        public DonXetNghiemServices(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<DonXetNghiem> addAsync(DonXetNghiem user)
        {
            var newstudent = await _httpClient.PostAsJsonAsync("api/DXN/Add-DXN", user);
            var respone = await newstudent.Content.ReadFromJsonAsync<DonXetNghiem>();
            return respone;
        }

        public async Task<DonXetNghiem> deleteAsync(int id)
        {
            var newstudent = await _httpClient.PostAsJsonAsync("api/DXN/Delete-DXN", id);
            var respone = await newstudent.Content.ReadFromJsonAsync<DonXetNghiem>();
            return respone;
        }

        public async Task<List<DonXetNghiem>> getallAsync()
        {
            var allstudent = await _httpClient.GetAsync("api/DXN/All-DXN");
            var respone = await allstudent.Content.ReadFromJsonAsync<List<DonXetNghiem>>();
            return respone;
        }

        public async Task<DonXetNghiem> getbyid(int Id)
        {
            var onestudent = await _httpClient.GetAsync("api/DXN/Single-DXN");
            var respone = await onestudent.Content.ReadFromJsonAsync<DonXetNghiem>();
            return respone;
        }

        public async Task<DonXetNghiem> updateAsync(DonXetNghiem User)
        {
            var newstudent = await _httpClient.PostAsJsonAsync("api/DXN/Update-DXN", User);
            var respone = await newstudent.Content.ReadFromJsonAsync<DonXetNghiem>();
            return respone;
        }
    }
}
