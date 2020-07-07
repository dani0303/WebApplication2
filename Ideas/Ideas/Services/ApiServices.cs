using Ideas.ViewModel;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;



namespace Ideas.Services
{
    public class ApiServices
    {
        public async Task<bool>RegisterAsync(string email, string password, string confirmPassword)
        {
            var client = new HttpClient();

            var model = new RegisterViewModel
            {
                Email = email, 
                Password = password,
                ConfirmPassword = confirmPassword
            };
            var json = JsonConvert.SerializeObject(model);

            HttpContent content = new StringContent(json);

            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await client.PostAsync("http://localhost:44314/api/Account/Register", content);

            return response.IsSuccessStatusCode;
        }
    }
}
