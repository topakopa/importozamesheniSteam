using Microsoft.EntityFrameworkCore;
using Steam.App.Infrastructure;
using Steam.DataBase;
using System.Linq;

namespace Steam.App.Models
{
    public class GameManager : IGameManager
    {
        private readonly SteamContext _steamContext = new SteamContext();
        public void DeleteGame(long userID, string gameName)
        {
            UserGame game = _steamContext.UserGames.Single(users => users.UserId == userID && users.GameName == gameName);

            _steamContext.UserGames.Remove(game);
            _steamContext.SaveChanges();
        }

        public UserGame GetUserGame(long userID, string gameName)
        {
            return _steamContext.UserGames.Single(users => users.UserId == userID && users.GameName == gameName);
        }

        public UserGame[] GetUserGames(long userID, string filter = null)
        {
            User user = _steamContext.Users.Include(u => u.UserGames).Single(users => users.Id == userID);
            UserGame[] games = user.UserGames.ToArray();

            if (string.IsNullOrEmpty(filter))
            {
                games = games.Where(u => u.GameName.ToLower().Contains(filter.ToLower())).ToArray();
            }

            return games;
        }
    }

    
}