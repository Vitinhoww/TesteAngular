using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TesteAngular.Models;

namespace TesteAngular.Data
{
    public class Context : DbContext
    {

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Country> Contry {get;set;}
    }
}
