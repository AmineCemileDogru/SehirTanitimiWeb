using System.Collections.Generic;
using System.Data.Entity;
using SehirTanitim.Models;

namespace SehirTanitim.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<SliderImage> SliderImages { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Population> Populations { get; set; }
        public DbSet<TouristPlace> TouristPlaces { get; set; }

        public MyDbContext() : base("MyDbContext") { }

    }
}
