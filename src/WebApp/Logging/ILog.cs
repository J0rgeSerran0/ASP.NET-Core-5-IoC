namespace WebApp.Logging
{
    public interface ILog
    {
        string Get();
        void Append(string message);
    }
}