using System;
using System.Net.Http;

namespace RestBusiness.RestHandlers
{
    public class RestHelper : IRestHelper
    {
        private readonly IRequestParameters _requestParameters;
        private readonly HttpClient _client;


        public RestHelper(IRequestParameters requestParameters)
        {
            _requestParameters = requestParameters;

            _client = PrpeareClient();
        }

        private HttpClient PrpeareClient()
        {
            var restClient = new RestClient();

            return restClient.GetRestClient(_requestParameters);
        }

        #region IRestHelper Members

        public TResult Get<TResult>(string uri)
        {
            var response = await _client.GetAsync(uri);

            return HandleResponse<TResult>(response);
        }

        public TResult Put<TInput, TResult>(string uri, TInput args)
        {
            throw new NotImplementedException();
        }

        public TResult Post<TInput, TResult>(string uri, TInput args)
        {
            throw new NotImplementedException();
        }

        public TResult Delete<TInput, TResult>(string uri, TInput args)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TResult HandleResponse<TResult>(HttpResponseMessage response)
        {
            return await response.Content.ReadAsAsync<TResult>();
        }

    }
}
