using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Steam.DataBase
{
    public class UserGame
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        public string GameName { get; set; }
        public string GameInfo { get; set; }
        public string GamePath { get; set; }
        public string ImagePath { get; set; }

    }
}
