using Steam.DataBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Steam.App.Infrastructure
{
    public interface IGameManager
    {
        void DeleteGame(long userID, string gameName);
        UserGame[] GetUserGames(long userID, string filter = null);
        UserGame GetUserGame(long gameID);
        UserGame GetUserGame(long userID, string gameName);
        void ChangeUserGameData(UserGame userGame);
        void AddUserGame(UserGame userGame);


    }
}
