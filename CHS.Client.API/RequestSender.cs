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

        public static LoginResponse Login(string username, string password, string facilityName = "وزارة الصحة والسكان")
        {
            using (HttpClient client = new HttpClient())
            {
                client.Timeout = TimeSpan.FromSeconds(30);
                string credentials = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{username}:{password}"));
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", credentials);
                client.DefaultRequestHeaders.Add("FacilityName", Convert.ToBase64String(Encoding.UTF8.GetBytes(facilityName)));
                HttpResponseMessage response = client.GetAsync("http://localhost:44332/api/Login").Result;
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
        
        public static TResponse SendRequest<TRequest, TResponse>(TRequest request) where TRequest : CHSRequest where TResponse : CHSResponse
        {
            ApiUri attribute = (ApiUri)Attribute.GetCustomAttribute(typeof(TResponse), typeof(ApiUri));
            using (HttpClient client = new HttpClient())
            {
                client.Timeout = TimeSpan.FromSeconds(30);
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                StringContent content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
                HttpResponseMessage response;
                if (attribute.Method == RequestMethod.Get)
                    response = client.GetAsync(attribute.Uri).Result;
                else
                    response = client.PostAsync(attribute.Uri, content).Result;
                string responseBody = response.Content.ReadAsStringAsync().Result;
                if (response.IsSuccessStatusCode)
                {
                    TResponse responseObject = JsonConvert.DeserializeObject<TResponse>(responseBody);
                    return responseObject;
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
