using Microsoft.EntityFrameworkCore;
using Module06_model.Models;

namespace Module06_model.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options) 
        {
            
        }

        public DbSet<Photo> Photos { get; set; }    
        public DbSet<Comments> Comments { get; set; }    
    }
}
