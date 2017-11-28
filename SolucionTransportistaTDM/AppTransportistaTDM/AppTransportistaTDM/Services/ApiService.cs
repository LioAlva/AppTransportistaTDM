using AppTransportistaTDM.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AppTransportistaTDM.Services
{
    public class ApiService
    {
 

        public ApiService()
        {
          //  ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client();
        }

        public async Task<Response> Login(string email, string password)
        {
            try
            {
                var loginRequest = new LoginRequest
                {
                    Email = email,
                    Password = password,
                };

               


                //var request = JsonConvert.SerializeObject(loginRequest);
                ////var content = new StringContent(request, Encoding.UTF8, "application/json");
                //var client = new HttpClient();
                //HttpContent httpContent = new StringContent(request);
                //httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                //client.BaseAddress = new Uri("http://tdmdigitalqa.azurewebsites.net/Service1.svc");
                ////var url1 = "http://tdmdigitalqa.azurewebsites.net/Service1.svc";
                //var url = "/ECommerce/api/Users/Login";
                //var response = await client.GetAsync(url);

                //if (!response.IsSuccessStatusCode)
                //{
                //    return new Response
                //    {
                //        IsSuccess = false,
                //        Message = "Usuario o contraseña incorrecta"
                //    };
                //}
                //var result = await response.Content.ReadAsStringAsync();
                //var user = JsonConvert.DeserializeObject<User>(result);

                return new Response
                {
                    IsSuccess = true,
                    Message = "Ok",
                    Result =null
                };

            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }
    }
}
