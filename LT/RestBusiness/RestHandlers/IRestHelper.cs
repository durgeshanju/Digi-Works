namespace RestBusiness.RestHandlers
{
    public interface IRestHelper
    {
        TResult Get<TInput, TResult>(TInput args);

        TResult Put<TInput, TResult>(TInput args);

        TResult Post<TInput, TResult>(TInput args);

        TResult Delete<TInput, TResult>(TInput args);

    }
}
