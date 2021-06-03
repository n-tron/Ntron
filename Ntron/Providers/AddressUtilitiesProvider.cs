using Newtonsoft.Json;
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
        private readonly IHttpClientFactory _httpClientFactory;
        public AddressUtilitiesProvider(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<CreateAddress.Response> CreateAddress(CreateAddress.Request model)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "ntron url");
            string content = JsonConvert.SerializeObject(model);
            request.Content = new StringContent(content, Encoding.UTF8, "application/json");

            HttpClient client = _httpClientFactory.CreateClient();
            HttpResponseMessage httpResponseMessage = await client.SendAsync(request);
            string result = httpResponseMessage.Content.ReadAsStringAsync().Result;

            CreateAddress.Response response = JsonConvert.DeserializeObject<CreateAddress.Response>(result);

            return response;
        }

        public async Task<GenerateAddress.Response> GenerateAddress()
        {
            throw new NotImplementedException();
        }

        public async Task<ValidateAddress.Response> ValidateAddress(ValidateAddress.Request model)
        {
            throw new NotImplementedException();
        }
    }
}
