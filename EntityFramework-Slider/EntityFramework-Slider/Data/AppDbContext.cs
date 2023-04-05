using EntityFramework_Slider.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework_Slider.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
       

       
        public DbSet<Blog> Blogs { get; set; }

        public DbSet<SliderInfo> SliderInfos { get; set; }

        public DbSet<Slider> Sliders { get; set; }




    }
}
