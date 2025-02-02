using BookNest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookNest.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Villa> Villas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s Lorem Ipsum.",
                    ImageUrl = "https://placehold.co/600x400",
                    Occupancy = 4,
                    Price = 200,
                    Sqft = 550
                },
                new Villa
                {
                    Id = 2,
                    Name = "Premium Pool Villa",
                    Description = "Donec nec posuere tortor. Aenean quis condimentum arcu, non ultricies sapien. Etiam condimentum elementum commodo. Etiam pulvinar ante eget iaculis efficitur.",
                    ImageUrl = "https://placehold.co/600x401",
                    Occupancy = 4,
                    Price = 300,
                    Sqft = 650
                },
                new Villa
                {
                    Id = 3,
                    Name = "Luxury Pool Villa",
                    Description = "Vestibulum hendrerit diam eget est iaculis finibus. Suspendisse nec metus sed metus posuere porttitor. Quisque sed leo sapien. Phasellus hendrerit hendrerit rutrum. Donec ut porta neque. Quisque condimentum blandit pretium.",
                    ImageUrl = "https://placehold.co/600x402",
                    Occupancy = 4,
                    Price = 450,
                    Sqft = 750
                }
                );
        }
    }
}
