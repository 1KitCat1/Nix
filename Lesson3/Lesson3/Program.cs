using System;
using System.Collections.Generic;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new FootballPlayer("Vasay", 11);
            var p2 = new FootballPlayer("Petay", 17);
            var p3 = new FootballPlayer("Xx", 12);
            var players = new List<FootballPlayer>();
            players.Add(p1);
            players.Add(p2);
            players.Add(p3);
            var team = new Team(players);
            team[1] = p1;
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(team[i].Info());
            }
        }
    }
}
