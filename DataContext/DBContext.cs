using Microsoft.EntityFrameworkCore;
using System.Xml;
using WebApi.Entities;

namespace WebApi.DataContext
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }

        public DBContext()
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseMySQL("server=localhost;database=MyDatabase;user=root;password=mypassword");
        //}

        public DbSet<Account> Accounts { get; set; }
    }
}
