

using APIs.ViewModels;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace APIs.Test
{
    public class IntegrationTest: IClassFixture<WebApplicationFactory<APIs.Startup>>
    {
        private readonly HttpClient _client;

        public IntegrationTest(WebApplicationFactory<APIs.Startup> fixture)
        {
            var appFactory = new WebApplicationFactory<Startup>();
            _client = fixture.CreateClient();
        }

        [Fact]
        public async Task Test()
        {
            _client.BaseAddress = new Uri("https://localhost:44371/api/api2/");
            var responseTask = await _client.GetAsync("calculajuros?valorInicial=100.00&tempo=1");
            Assert.Equal(HttpStatusCode.OK, responseTask.StatusCode);


        }

        [Fact]
        public async Task Test2()
        {
            _client.BaseAddress = new Uri("https://localhost:44371/api/api2/");
            var responseTask = await _client.GetAsync("showmethecode");
            Assert.Equal(HttpStatusCode.OK, responseTask.StatusCode);


        }

    }
}
