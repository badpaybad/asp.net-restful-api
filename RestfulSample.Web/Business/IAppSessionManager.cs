namespace RestfulSample.Web.Business
{
    public interface IAppSessionManager
    {
        bool GetToken(string apikey, out string token);
        bool IsValidSession(string token);
        void KeepSession(string token);
        void RemoveSession(string token);
    }
}