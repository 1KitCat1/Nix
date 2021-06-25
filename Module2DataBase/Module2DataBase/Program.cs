using System;
using System.Data.Entity;
using System.Linq;
namespace Module2DataBase
{

    class Program
    {
        static void Main(string[] args)
        {
            //Добавление записи в БД
            Console.WriteLine("Do you want to add new client? (YES|NO)");
            var inputString = Console.ReadLine();
            if(inputString == "YES" || inputString == "Yes")
            {
                string name, address;
                int balance;
                Console.WriteLine("Write NAME of the new client");
                name = Console.ReadLine();
                Console.WriteLine("Write ADDRESS of the new client");
                address = Console.ReadLine();
                Console.WriteLine("Write BALANCE of the new client");
                balance = Convert.ToInt32( Console.ReadLine());
                var newClient = new Client
                {
                    Name = name,
                    Address = address,
                    Balance = balance
                };
                using (var context = new DataBase())
                {
                    context.Clients.Add(newClient);
                    context.SaveChanges();
                }
            }
        
            Console.WriteLine("Do you want to delete data?");
            string input = Console.ReadLine();
            if(input == "YES")
            {
                //Удаление записи в БД
                using (var context = new DataBase())
                {
                    var delClient = context.Clients
                   .Where(o => o.Name == "Ivan")
                   .FirstOrDefault();
                    context.Clients.Remove(delClient);
                    context.SaveChanges();
                }
            }
            
            //Печать всех клентов
            using (var context = new DataBase())
            {
                var clients = context.Clients;
                foreach(var client in clients)
                {
                    Console.WriteLine($"Name: {client.Name} | Address:{client.Address}");
                }
            }
            using(var context = new DataBase())
            {
                context.SaveChanges();
            }
            Console.ReadLine();
        }
    }
}
