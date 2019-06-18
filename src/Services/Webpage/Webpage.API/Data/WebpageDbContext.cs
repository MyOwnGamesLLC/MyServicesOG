using Microsoft.EntityFrameworkCore;
using Webpage.API.Model;

namespace Webpage.API.Data
{
    public class WebpageDbContext : DbContext
    {

        public WebpageDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Page> Pages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Block> Blocks { get; set; }


    }

}
