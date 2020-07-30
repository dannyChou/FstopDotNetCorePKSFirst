using Microsoft.Extensions.Configuration;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.MVC.Helper
{
    public class GatewayServiceHelper : IServiceHelper
    {
        public GatewayServiceHelper(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public async Task<string> GetOrder()
        {
            Uri apiGateway = new Uri(Configuration["ConsulSetting:ConsulAddress"]);
            var Client = new RestClient(apiGateway);
            var request = new RestRequest("/orders", Method.GET);

            var response = await Client.ExecuteAsync(request);
            return response.Content;
        }

        public async Task<string> GetProduct()
        {
            Uri apiGateway = new Uri(Configuration["ConsulSetting:ConsulAddress"]);
            var Client = new RestClient(apiGateway);
            var request = new RestRequest("/products", Method.GET);

            var response = await Client.ExecuteAsync(request);
            return response.Content;
        }

        public void GetServices()
        {
            throw new NotImplementedException();
        }

    }
}
