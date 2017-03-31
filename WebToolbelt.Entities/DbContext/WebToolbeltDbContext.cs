using Microsoft.EntityFrameworkCore;
using WebToolbelt.Entities.Entities;

namespace WebToolbelt.Entities.DbContext
{
   public  class WebToolbeltDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public WebToolbeltDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Language> Languages { get; set; }
    }
}
