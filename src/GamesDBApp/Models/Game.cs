using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesDBApp.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Developer { get; set; }
        public DateTime ReleaseDate { get; set; }

        
    }
}
