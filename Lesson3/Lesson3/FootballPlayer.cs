using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class FootballPlayer
    {
        public string Name { get; }
        public int Number { get; protected set; }
        public FootballPlayer(string name, int num)
        {
            Name = name;
            Number = num;
        }
        public string Info()
        {
            return $"Name {Name}, number {Number}";
        }
    }
}
