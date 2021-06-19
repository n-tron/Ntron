using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Ntron.Helpers;
using Ntron.Models.AddressUtilities;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Ntron.Providers
{
    public interface IAddressUtilitiesProvider
    {
        Task<GenerateAddress.Response> GenerateAddress();
        Task<CreateAddress.Response> CreateAddress(CreateAddress.Request model);
        Task<ValidateAddress.Response> ValidateAddress(ValidateAddress.Request model);
        
    }
    public class AddressUtilitiesProvider : IAddressUtilitiesProvider
    {
        private readonly INtron _ntron;
        private readonly IHttpClientFactory _httpClientFactory;

        public AddressUtilitiesProvider(INtron ntron, IHttpClientFactory httpClientFactory)
        {
            _ntron = ntron;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<CreateAddress.Response> CreateAddress(CreateAddress.Request model)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, $"{_ntron.Url}/wallet/createAddress");
            string content = JsonConvert.SerializeObject(model);
            request.Content = new StringContent(content, Encoding.UTF8, "application/json");
            request.Headers.Add("TRON-PRO-API-KEY", _ntron.APIKey);

            HttpClient client = _httpClientFactory.CreateClient();
            HttpResponseMessage httpResponseMessage = await client.SendAsync(request);
            string result = httpResponseMessage.Content.ReadAsStringAsync().Result;

            CreateAddress.Response response = JsonConvert.DeserializeObject<CreateAddress.Response>(result);

            return response;
        }

        public async Task<GenerateAddress.Response> GenerateAddress()
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"{_ntron.Url}/wallet/generateAddress");
            request.Headers.Add("TRON-PRO-API-KEY", _ntron.APIKey);

            HttpClient client = _httpClientFactory.CreateClient();
            HttpResponseMessage httpResponseMessage = await client.SendAsync(request);
            string result = httpResponseMessage.Content.ReadAsStringAsync().Result;

            GenerateAddress.Response response = JsonConvert.DeserializeObject<GenerateAddress.Response>(result);

            return response;
        }

        public async Task<ValidateAddress.Response> ValidateAddress(ValidateAddress.Request model)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, $"{_ntron.Url}/wallet/validateaddress");
            string content = JsonConvert.SerializeObject(model);
            request.Content = new StringContent(content, Encoding.UTF8, "application/json");
            request.Headers.Add("TRON-PRO-API-KEY", _ntron.APIKey);

            HttpClient client = _httpClientFactory.CreateClient();
            var httpResponseMessage = await client.SendAsync(request);
            string result = httpResponseMessage.Content.ReadAsStringAsync().Result;

            ValidateAddress.Response response = JsonConvert.DeserializeObject<ValidateAddress.Response>(result);

            return response;
        }
    }
}
