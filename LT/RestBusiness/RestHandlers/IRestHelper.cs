namespace RestBusiness.RestHandlers
{
    public interface IRestHelper
    {
        TResult Get<TResult>(string uri);

        TResult Put<TInput, TResult>(string uri,TInput args);

        TResult Post<TInput, TResult>(string uri,TInput args);

        TResult Delete<TInput, TResult>(string uri,TInput args);
        
    }
}
