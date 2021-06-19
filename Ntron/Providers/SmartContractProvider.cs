using Newtonsoft.Json;
using Ntron.Models.SmartContract;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Ntron.Providers
{
    public interface ISmartContractProvider 
    {
        Task<object> GetContract(GetContract.Request model);
        TriggerSmartContract.Response TriggerSmartContract(TriggerSmartContract.Request model);
        Task<object> DeployContract(DeployContract.Request model);

    }
    public class SmartContractProvider : ISmartContractProvider
    {
        private readonly INtron _ntron;
        private readonly IHttpClientFactory _httpClientFactory;

        public SmartContractProvider(INtron ntron, IHttpClientFactory httpClientFactory)
        {
            _ntron = ntron;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<object> DeployContract(DeployContract.Request model)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, $"{_ntron.Url}/wallet/deploycontract");
            string content = JsonConvert.SerializeObject(model);
            request.Content = new StringContent(content, Encoding.UTF8, "application/json");
            request.Headers.Add("TRON-PRO-API-KEY", _ntron.APIKey);

            HttpClient client = _httpClientFactory.CreateClient();
            HttpResponseMessage httpResponseMessage = await client.SendAsync(request);
            string result = httpResponseMessage.Content.ReadAsStringAsync().Result;

            object response = JsonConvert.DeserializeObject<object>(result);

            return response;
        }

        public Task<object> GetContract(GetContract.Request model)
        {
            throw new NotImplementedException();
        }

        public TriggerSmartContract.Response TriggerSmartContract(TriggerSmartContract.Request model)
        {
            throw new NotImplementedException();
        }

    }
}
