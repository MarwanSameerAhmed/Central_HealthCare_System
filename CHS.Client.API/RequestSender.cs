using CHS.Client.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;

namespace CHS.Client.API
{
    public class RequestSender
    {
        private static string token = "";

        public static LoginResponse Login(string username, string password)
        {
            using (HttpClient client = new HttpClient())
            {
                client.Timeout = TimeSpan.FromSeconds(30);
                string credentials = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{username}:{password}"));
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", credentials);
                HttpResponseMessage response = client.GetAsync(RoutesOfRequest.BASE_URL + RoutesOfRequest.LOGIN).Result;
                string responseBody = response.Content.ReadAsStringAsync().Result;
                if (response.IsSuccessStatusCode)
                {
                    LoginResponse loginResponse = JsonConvert.DeserializeObject<LoginResponse>(responseBody);
                    token = loginResponse.Token;
                    return loginResponse;
                }
                else if(response.StatusCode == HttpStatusCode.BadRequest || response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    CHSResponse chsResponse = JsonConvert.DeserializeObject<CHSResponse>(responseBody);
                    throw new Exception(chsResponse.MessageDescription);
                }
                else throw new Exception(responseBody);
            }
        } 
    }
}
