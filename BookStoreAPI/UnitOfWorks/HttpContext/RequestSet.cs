using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWorks.HttpContext
{
    public class RequestSet<TRequest> where TRequest : class, IRequest, new()
    {
        private HttpClient httpClient;

        public TRequest Data
        {
            get;
            set;
        }

        public RequestSet(HttpContextBase httpContextBase)
        {
            var attribute = typeof(TRequest).GetCustomAttributes(typeof(DataContractAttribute), true).FirstOrDefault() as DataContractAttribute;
            Method = attribute?.Name;
            HostUrl = httpContextBase.CreateHostUrl(true);
        }

        public string Method { get; private set; }

        public string HostUrl { get; private set; }

        private HttpClient CreateClient()
        {
            return new HttpClient()
            {
                BaseAddress = new Uri(HostUrl)
            };
        }

        protected virtual async Task<ResponseGet<TResponse>> HandleResponse<TResponse>(HttpResponseMessage responseMessage) where TResponse : class, IResponse, new()
        {
            ResponseGet<TResponse> response = new ResponseGet<TResponse>();
            response.Code = responseMessage.StatusCode.ToString("d");
            response.Message = Enum.GetName(typeof(System.Net.HttpStatusCode), responseMessage.StatusCode);
            if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var data = await responseMessage.Content.ReadAsStringAsync();
                response.Data = Newtonsoft.Json.JsonConvert.DeserializeObject<TResponse>(data);
            }
            return response;
        }

        protected virtual ResponseGet<TResponse> HandleException<TResponse>(HttpContextException exception) where TResponse : class, IResponse, new()
        {
            ResponseGet<TResponse> response = new ResponseGet<TResponse>();
            response.Code = exception.ResponseMessage.StatusCode.ToString("d");
            response.Message = exception.Message;
            return response;
        }

        public async Task<ResponseGet<TResponse>> GetAsync<TResponse>() where TResponse : class, IResponse, new()
        {
            return await DoGetAsync<TResponse>(Data, Method);
        }

        private async Task<ResponseGet<TResponse>> DoGetAsync<TResponse>(TRequest request, string methodUrl) where TResponse : class, IResponse, new()
        {
            try
            {
                using (httpClient = CreateClient())
                {
                    
                    var resquestUrl = HostUrl + methodUrl;
                    IList<string> fieds = new List<string>();
                    var stringContent = JsonConvert.SerializeObject(request);
                    var parameters = JsonConvert.DeserializeObject<IDictionary<string, object>>(stringContent);
                    if (parameters != null)
                    {
                        foreach (var paramerter in parameters)
                        {
                            fieds.Add($"{paramerter.Key}={paramerter.Value}");
                        }
                    }
                    resquestUrl += fieds.Count > 0 ? "?" + string.Join("&", fieds) : string.Empty;
                    var response = await httpClient.GetAsync(new Uri(resquestUrl));
                    return await HandleResponse<TResponse>(response);
                }
            }
            catch (HttpContextException ex)
            {
                return HandleException<TResponse>(ex);
            }
        }
    }
}
