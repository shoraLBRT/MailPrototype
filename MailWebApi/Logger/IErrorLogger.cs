namespace MailWebApi.Logger
{
    public interface IErrorLogger
    {
        void LogError(Exception ex);
    }
}
