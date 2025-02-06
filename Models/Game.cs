using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesLibrary2.Models
{
    // Models/Game.cs
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public int NumberOfCards { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
