using System;
using System.Collections.Generic;
using System.Linq;

namespace LessonLINQ
{
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Phone
    {
        public string Name { get; set; }
        public string Company { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>()
            {
                new User {Name = "Adam", Age = 34},
                new User {Name = "Mark", Age = 19}
            };
            var people = from user in users
                         where user.Age > 20
                         select new { Name = user.Name, Age = user.Age };
            foreach(var person in people)
            {
                Console.WriteLine(person.Name);
            }
        }
    }
}
