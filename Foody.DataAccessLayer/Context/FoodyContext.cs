using Foody.EntitiyLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Foody.DataAccessLayer.Context
{
    public class FoodyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-2O56BVB;Initial Catalog=FoodyFb;Integrated Security=True");
        }

        // Burada birincil anahtarı açıkça tanımlıyoruz
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .HasKey(a => a.AdressId); // Address için birincil anahtar tanımlandı
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
    }
}
