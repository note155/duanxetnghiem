using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Shared.form;
using Shared.Model;
using System.Text;
using System.Text.Json;
using Shared.ketnoi;
using Recruit.Client;
using System.Security.Claims;

namespace duanxetnghiem.Client.Services
{
    public class AccService :Iaccount
    {
        private readonly HttpClient _httpClient;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly ILocalStorageService _localStorageService;

        public AccService(HttpClient httpClient,
            AuthenticationStateProvider authenticationStateProvider,
            ILocalStorageService localStorageService)
        {
            _httpClient = httpClient;
            _authenticationStateProvider = authenticationStateProvider;
            _localStorageService = localStorageService;
        }

        public async Task<acc> Login(loginform user)
        {
            var dataJson = JsonSerializer.Serialize(user);
            var response = await _httpClient.PostAsync("api/acc/Login", new StringContent(dataJson, Encoding.UTF8, "application/json"));
            var loginResult = JsonSerializer.Deserialize<acc>(await response.Content.ReadAsStringAsync(),
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            if (!response.IsSuccessStatusCode)
            {
                return loginResult ?? new acc();
            }

            await _localStorageService.SetItemAsync("email", loginResult?.Email ?? string.Empty);
            await _localStorageService.SetItemAsync("loaiacc", loginResult?.loaiacc ?? string.Empty);
            ((CustomAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(user.Email, loginResult?.loaiacc!);

            return loginResult;
        }
      

        private void NotifyAuthenticationStateChanged(Task<AuthenticationState> authState)
        {
            throw new NotImplementedException();
        }

        public Task<acc> Logout()
        {
            throw new NotImplementedException();
        }
    }
}