using EntityFramework_practice.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework_practice.Data
{
    public class AppDbContext: DbContext  
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
      
        
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<SliderInfo> SliderInfos { get; set; }

    }
}
