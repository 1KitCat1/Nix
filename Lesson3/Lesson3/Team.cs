using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Team
    {
        public List<FootballPlayer> Players;
        public Team(List<FootballPlayer> players)
        {
            Players = players;
        }
        public FootballPlayer this[int index]
        {
            get
            {
                if(index >= Players.Count)
                {
                    return new FootballPlayer("", -1);
                }
                return Players[index];
            }
            set
            {
                Players[index] = value;
            }
        }
    }
}
