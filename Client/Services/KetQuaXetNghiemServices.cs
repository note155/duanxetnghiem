using duanxetnghiem.Data.Model;
using Shared.ketnoi;
using System.Net.Http.Json;

namespace duanxetnghiem.Client.Services
{
    public class KetQuaXetNghiemServices :IKetQuaXetNghiem
    {
        private readonly HttpClient _httpClient;
        public KetQuaXetNghiemServices(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<KetQuaXetNghiem> addAsync(KetQuaXetNghiem user)
        {
            var newstudent = await _httpClient.PostAsJsonAsync("api/KQXN/Add-KQXN", user);
            var respone = await newstudent.Content.ReadFromJsonAsync<KetQuaXetNghiem>();
            return respone;
        }

        public async Task<KetQuaXetNghiem> deleteAsync(int id)
        {
            var newstudent = await _httpClient.PostAsJsonAsync("api/KQXN/Delete-KQXN", id);
            var respone = await newstudent.Content.ReadFromJsonAsync<KetQuaXetNghiem>();
            return respone;
        }

        public async Task<List<KetQuaXetNghiem>> getallAsync()
        {
            var allstudent = await _httpClient.GetAsync("api/KQXN/All-KQXN");
            var respone = await allstudent.Content.ReadFromJsonAsync<List<KetQuaXetNghiem>>();
            return respone;
        }

        public async Task<KetQuaXetNghiem> getbyid(int Id)
        {
            var onestudent = await _httpClient.GetAsync("api/KQXN/Single-KQXN");
            var respone = await onestudent.Content.ReadFromJsonAsync<KetQuaXetNghiem>();
            return respone;
        }

        public async Task<KetQuaXetNghiem> updateAsync(KetQuaXetNghiem User)
        {
            var newstudent = await _httpClient.PostAsJsonAsync("api/KQXN/Update-KQXN", User);
            var respone = await newstudent.Content.ReadFromJsonAsync<KetQuaXetNghiem>();
            return respone;
        }
    }
}
