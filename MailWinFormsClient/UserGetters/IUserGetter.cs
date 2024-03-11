namespace MailWinFormsClient.UserGetters
{
    internal interface IUserGetter
    {
        Task<object>? GetUsers();
    }
}
