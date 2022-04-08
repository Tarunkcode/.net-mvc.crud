
using Card.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CardRecord.Data
{
    public class CardsDbContext : DbContext
    {
        public CardsDbContext(DbContextOptions options) : base(options)
        {
        }
        // DbSet : It is a property and it is used by entity framework core and it acts like a table in sql server

        // property of a DbSet width the type of card name Cards i.e, means Cards is just a exact replica of sql server table cardl
       public DbSet<modal> modals { get; set; }
       
    }
}
