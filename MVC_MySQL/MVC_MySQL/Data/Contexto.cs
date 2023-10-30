using Microsoft.EntityFrameworkCore;
using MVC_MySQL.Models;

namespace MVC_MySQL.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuario { get; set; }
    }
}
