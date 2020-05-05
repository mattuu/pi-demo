using Microsoft.EntityFrameworkCore;
using pi_demo.DataAccess.Entities;

namespace pi_demo.DataAccess
{
    public class ItemsDatabaseContext : DbContext
    {
        public ItemsDatabaseContext(DbContextOptions<ItemsDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
    }
}