using System;
using System.Net.Http;

namespace RestBusiness.RestHandlers
{
    public class RestHelper : IRestHelper
    {
        private IRequestParameters _requestParameters;

        public RestHelper(IRequestParameters requestParameters)
        {
            _requestParameters = requestParameters;
        }

        private HttpClient PrpeareClient()
        {
            return  new HttpClient();
        }

        #region IRestHelper Members

        public TResult Get<TInput, TResult>(TInput args)
        {
            throw new NotImplementedException();
        }

        public TResult Put<TInput, TResult>(TInput args)
        {
            throw new NotImplementedException();
        }

        public TResult Post<TInput, TResult>(TInput args)
        {
            throw new NotImplementedException();
        }

        public TResult Delete<TInput, TResult>(TInput args)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
