
using System;
using System.Collections.Generic;
using System.Text;

namespace Steam.DataBase
{
    public class User
    {
        public long Id { get; set; }
        public List <UserGame> UserGames { get; set; }
        public string Login { get; set; }
        public string Pasword { get; set; }
        public string Nikname { get; set; }
    }
}
