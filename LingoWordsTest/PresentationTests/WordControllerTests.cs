using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Threading.Tasks;
using System.Net.Http;
using System;
using Moq;
using System.Collections.Generic;
using LingoWords;

namespace LingoWordsTest.PresentationTests
{
    public class WordControllerTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly HttpClient client;

        public WordControllerTests()
        {
            var factory = new WebApplicationFactory<Startup>();
            client = factory.CreateClient();
        }

        [Theory]
        [InlineData("/Word")]
        public async Task Get_EndpointsReturnSuccessAndCorrectContentType(string url)
        {
            var response = await client.GetAsync(url);

            response.EnsureSuccessStatusCode();
            Assert.Equal("OK", response.StatusCode.ToString());
        }

    }
}
