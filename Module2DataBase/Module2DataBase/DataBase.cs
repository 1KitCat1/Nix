using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Module2DataBase
{
    public class DataBase : DbContext
    {
        public DataBase() : base("DbConnectionString")
        {

        }
        public DbSet<Client> Clients { get; set; }
    }
}
