using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApiExample.Domain;
using Xunit;

namespace WebApiExample.Tests
{
    public class CustomerTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public CustomerTests(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task CanRetrieveCustomer()
        {
            var client = _factory.CreateClient();
            var response = await client.GetAsync("/customers/1");

            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            Assert.NotEmpty(json);
        }
    }
}
