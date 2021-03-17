using System;
using System.Collections.Generic;
using System.Text;

namespace HuntTheWumpusConsole
{
    class Game
    {
        public Game(int mapSize)
        {
            gameMap = new Map(mapSize);
        }
        public Map gameMap { get; set; }

    }

}
