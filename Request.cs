using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Request
    {
        private static HttpClient _client = new HttpClient(){ BaseAddress = new Uri("http://localhost:60910/")};

        public async Task<HttpResponseMessage> Authorization(string login, string pass, Boolean remember = false)
        {
            var registerModel = new {username = login, password = pass, rememberMe = remember};
            var stringApiAuth = JsonSerializer.Serialize(registerModel);
                
            var request = new HttpRequestMessage(HttpMethod.Post, "/api/account/login") {Content = new StringContent(stringApiAuth, Encoding.UTF8, "application/json")};
            return await _client.SendAsync(request);
        }

        public async Task<HttpResponseMessage> SendCreateMeeting(CreateMeetingDto createMeetingDto)
        {
            var stringApi = JsonSerializer.Serialize(createMeetingDto);
            var request = new HttpRequestMessage(HttpMethod.Post, "/api/v2.0/meetings") {Content = new StringContent(stringApi, Encoding.UTF8, "application/json")};
            return await _client.SendAsync(request);
        }

        public async Task<IssueRefDto> SendCreateIssue(CreateIssueDto createIssueDto)
        {
            var stringApi = JsonSerializer.Serialize(createIssueDto);
            var request = new HttpRequestMessage(HttpMethod.Post, "/api/v2.0/issues") {Content = new StringContent(stringApi, Encoding.UTF8, "application/json")};
            var res =  await _client.SendAsync(request);
            var test = res.Content.ToString();
            var r = JsonSerializer.Deserialize<IssueRefDto>(test);
            return r;
        }
        
    }
}