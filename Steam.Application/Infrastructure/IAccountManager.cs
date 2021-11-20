using Steam.DataBase;

namespace Steam.App.Infrastructure
{
    public interface IAccountManager
    {
        bool Registration(string login, string password, string directPassword);
        bool ChangePassword(long id, string newPassword);
        bool ChangeLogin(long id, string newLogin);
        void ChangeNickname(long id, string newNick);
        long Authorization(string login, string password);
        bool Delete(long id);
        User GetUser(long id);


    }
}
