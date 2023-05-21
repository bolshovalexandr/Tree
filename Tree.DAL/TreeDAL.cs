using Microsoft.EntityFrameworkCore;
using Tree.DAL.Domain.Genre;

namespace Tree.DAL
{
    public class TreeDAL
    {
        public class PostgreeContext : DbContext
        {
            public PostgreeContext(DbContextOptions<PostgreeContext> options)
                : base(options)
            {
            }

            public DbSet<Genre> Genres { set; get; }

        }

    }
}