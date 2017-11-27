﻿using AppTransportistaTDM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTransportistaTDM.Services
{
    public class ApiService
    {

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
                //var content = new StringContent(request, Encoding.UTF8, "application/json");
                //var client = new HttpClient();
                //client.BaseAddress = new Uri("http://zulu-software.com");
                ////client.BaseAddress = new Uri("http://luisperseo-001-site1.itempurl.com");
                ////var url = "/api/Users/Login";
                //var url = "/ECommerce/api/Users/Login";
                //var response = await client.PostAsync(url, content);

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