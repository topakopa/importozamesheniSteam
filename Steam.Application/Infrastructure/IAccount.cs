namespace Steam.App.Infrastructure
{
    public interface IAccount
    {
        bool Registration(string login, string password, string directPassword);
        bool ChangePassword(long id, string newPassword);
        bool ChangeLogin(long id, string newLogin);
        long Authorization(string login, string password);
        bool Delete(long id);
    }
}
