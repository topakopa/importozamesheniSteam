using Steam.Application.Infrastructure;
using Steam.DataBase;
using System;
using System.Linq;

namespace Steam.Application.Models
{
    public class Account : IAccount
    {
        public bool ChangeLogin(long id, string newLogin)
        {
            if (string.IsNullOrEmpty(newLogin))
            {
                throw new Exception("Логин пуст");
            }

            SteamContext context = new SteamContext();
            User user = context.Users.Single(u => u.Id == id);

            User existUser = context.Users.FirstOrDefault(u => u.Login == newLogin);

            if (existUser == null)
            {
                user.Login = newLogin;
                return true;
            }
            else
            {
                throw new Exception("Этот логин занят");
            }
        }

        public bool ChangePassword(long id, string newPassword)
        {
            if (String.IsNullOrEmpty(newPassword))
            {
                throw new Exception("Новый пароль пуст");
            }

            SteamContext context = new SteamContext();

            User user = context.Users.Single(u => u.Id == id);
            user.Pasword = newPassword;

            context.SaveChanges();

            return true;
        }

        public long Authorization(string login, string password)
        {
            SteamContext context = new SteamContext();
            User user = context.Users.FirstOrDefault(u => u.Login == login && u.Pasword == password);

            if (user != null)
            {
                //TODO: вынести из метода
                //Console.Beep(260, 200);
                //Console.Beep(370, 300);
                return user.Id;
            }
            else
            {
                //Console.Beep(200, 300);
                //Console.Beep(37, 500);
                throw new Exception("Неверный логин или пароль");
            }
        }

        public bool Registration(string login, string password, string directPassword)
        {
            SteamContext context = new SteamContext();

            if (string.IsNullOrEmpty(login))
            {
                throw new Exception("Логин пуст");
            }

            if (string.IsNullOrEmpty(password))
            {
                throw new Exception("Пароль пуст");
            }

            if (password == directPassword)
            {
                User user = context.Users.FirstOrDefault(u => u.Login == login);
                if (user != null)
                {
                    throw new Exception("Этот логин занят");
                }
                else
                {
                    context.Users.Add(new User()
                    {
                        Login = login,
                        Pasword = password,
                        Nikname = login
                    });
                    context.SaveChanges();
                    return true;
                }
            }
            else
            {
                throw new Exception("Пароли не совпадают");
            }
        }

        public bool Delete(long id)
        {
            SteamContext context = new SteamContext();
            User user = context.Users.Single(u => u.Id == id);

            context.Users.Remove(user);
            return true;
        }
    }
}

