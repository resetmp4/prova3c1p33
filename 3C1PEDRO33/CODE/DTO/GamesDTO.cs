using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1PEDRO33.CODE.DTO
{
    internal class GamesDTO
    {
        private int _id;
        private string _games, _perifericos, _videogames;

        public int Id { get => _id; set => _id = value; }
        public string Games { get => _games; set => _games = value; }
        public string Perifericos { get => _perifericos; set => _perifericos = value; }
        public string Videogames { get => _videogames; set => _videogames = value; }
    }
}
