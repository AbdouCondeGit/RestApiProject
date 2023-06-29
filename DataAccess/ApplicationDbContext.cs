using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }
        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaValue> VillaValues { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Villa>().HasData(
    new Villa
    {
        Id = 1,
        Name = "Villa Ephrussi de Rothschild",
        Details = "Villa Ephrussi de Rothschild is located in Saint-Jean-Cap-Ferrat on the French Riviera. It offers panoramic views of the Mediterranean Sea and magnificent gardens.",
        ImageUrl = "paradisiaque6.jpg",
        Occupancy = 4,
        Rate = 200,
        Sqft = 550,
        Amenity = "",
        CreatedDate = DateTime.Now,
        CreatedBy = "Abdou",
        UpdateDate = DateTime.Now
    },
    new Villa
    {
        Id = 2,
        Name = "Villa Kérylos",
        Details = "Villa Kérylos is a faithful reconstruction of an ancient Greek residence located in Beaulieu-sur-Mer on the French Riviera. It offers a unique experience in a stunning setting.",
        ImageUrl = "paradisiaque7.jpg",
        Occupancy = 4,
        Rate = 200,
        Sqft = 550,
        Amenity = "",
        CreatedDate = DateTime.Now,
        CreatedBy = "Abdou",
        UpdateDate = DateTime.Now
    },
    new Villa
    {
        Id = 3,
        Name = "Villa La Roche",
        Details = "Villa La Roche, designed by architect Le Corbusier, is located in Paris. It houses a collection of modern art and provides an interesting perspective on 20th-century architecture.",
        ImageUrl = "paradisiaque8.jpg",
        Occupancy = 4,
        Rate = 200,
        Sqft = 550,
        Amenity = "",
        CreatedDate = DateTime.Now,
        CreatedBy = "Abdou",
        UpdateDate = DateTime.Now
    },
    new Villa
    {
        Id = 4,
        Name = "Villa Savoye",
        Details = "Villa Savoye, another iconic creation by Le Corbusier, is considered a masterpiece of modern architecture. It is located in Poissy, France.",
        ImageUrl = "paradisiaque9.jpg",
        Occupancy = 4,
        Rate = 200,
        Sqft = 550,
        Amenity = "",
        CreatedDate = DateTime.Now,
        CreatedBy = "Abdou",
        UpdateDate = DateTime.Now
    },
     new Villa
     {
         Id = 5,
         Name = "Villa Balbianello",
         Details = "Villa Balbianello is located on the shores of Lake Como in Italy, accessible from France. It is surrounded by beautiful terraced gardens and offers spectacular views of the lake.",
         ImageUrl = "paradisiaque10.jpg",
         Occupancy = 4,
         Rate = 200,
         Sqft = 550,
         Amenity = "",
         CreatedDate = DateTime.Now,
         CreatedBy = "Abdou",
         UpdateDate = DateTime.Now
     },
    new Villa
    {
        Id = 6,
        Name = "Villa Noailles",
        Details = "Villa Noailles is a modernist villa in Hyères. It houses an art and architecture center and hosts the International Festival of Fashion and Photography in Hyères.",
        ImageUrl = "paradisiaque11.jpg",
        Occupancy = 4,
        Rate = 200,
        Sqft = 550,
        Amenity = "",
        CreatedDate = DateTime.Now,
        CreatedBy = "Abdou",
        UpdateDate = DateTime.Now
    },
    new Villa
    {
        Id = 7,
        Name = "Villa Domergue",
        Details = "Villa Domergue is an Art Deco villa located on the hills of Cannes. It offers breathtaking views of the city and the sea.",
        ImageUrl = "paradisiaque12.jpg",
        Occupancy = 4,
        Rate = 200,
        Sqft = 550,
        Amenity = "",
        CreatedDate = DateTime.Now,
        CreatedBy = "Abdou",
        UpdateDate = DateTime.Now
    },
    new Villa
    {
        Id = 8,
        Name = "Villa Les Cèdres",
        Details = "Villa Les Cèdres is the former residence of King Leopold II of Belgium. It is located in Saint-Jean-Cap-Ferrat and is surrounded by vast botanical gardens and an impressive art collection.",
        ImageUrl = "paradisiaque13.jpg",
        Occupancy = 4,
        Rate = 200,
        Sqft = 550,
        Amenity = "",
        CreatedDate = DateTime.Now,
        CreatedBy = "Abdou",
        UpdateDate = DateTime.Now
    },
    new Villa
    {
        Id = 9,
        Name = "Villa Médicis",
        Details = "Villa Médicis is a Renaissance villa located in Rome, Italy. It serves as the French Academy in Rome and hosts various artists and scholars.",
        ImageUrl = "paradisiaque14.jpg",
        Occupancy = 4,
        Rate = 200,
        Sqft = 550,
        Amenity = "",
        CreatedDate = DateTime.Now,
        CreatedBy = "Abdou",
        UpdateDate = DateTime.Now
    }
    , new Villa
    {
        Id = 10,
        Name = "Malibu Beach Villa",
        Details = "The Malibu Beach Villa is a luxurious oceanfront retreat located in Malibu, California. It offers stunning views of the Pacific Ocean and direct access to the beach.",
        ImageUrl = "paradisiaque15.jpg",
        Occupancy = 4,
        Rate = 200,
        Sqft = 550,
        Amenity = "",
        CreatedDate = DateTime.Now,
        CreatedBy = "Abdou",
        UpdateDate = DateTime.Now
    },
    new Villa
    {
        Id = 11,
        Name = "Aspen Mountain Chalet",
        Details = "The Aspen Mountain Chalet is nestled in the scenic mountains of Aspen, Colorado. It features a cozy interior, breathtaking views, and convenient access to skiing and outdoor activities.",
        ImageUrl = "paradisiaque16.jpg",
        Occupancy = 4,
        Rate = 200,
        Sqft = 550,
        Amenity = "",
        CreatedDate = DateTime.Now,
        CreatedBy = "Abdou",
        UpdateDate = DateTime.Now
    },
    new Villa
    {
        Id = 12,
        Name = "Hawaiian Paradise Villa",
        Details = "The Hawaiian Paradise Villa is a tropical oasis located on the island of Maui, Hawaii. It offers a private pool, lush gardens, and easy access to beautiful beaches.",
        ImageUrl = "paradisiaque17.jpg",
        Occupancy = 4,
        Rate = 200,
        Sqft = 550,
        Amenity = "",
        CreatedDate = DateTime.Now,
        CreatedBy = "Abdou",
        UpdateDate = DateTime.Now
    },
    new Villa
    {
        Id = 13,
        Name = "Miami Beachfront Villa",
        Details = "The Miami Beachfront Villa is a luxurious waterfront property located in Miami, Florida. It features modern design, panoramic ocean views, and a private dock for boating enthusiasts.",
        ImageUrl = "paradisiaque18.jpg",
        Occupancy = 4,
        Rate = 200,
        Sqft = 550,
        Amenity = "",
        CreatedDate = DateTime.Now,
        CreatedBy = "Abdou",
        UpdateDate = DateTime.Now
    },
    new Villa
    {
        Id = 14,
        Name = "Lake Tahoe Retreat",
        Details = "The Lake Tahoe Retreat is a serene getaway nestled in the breathtaking mountains of Lake Tahoe, California. It offers a tranquil setting, outdoor activities, and access to the stunning lake.",
        ImageUrl = "paradisiaque19.jpg",
        Occupancy = 4,
        Rate = 200,
        Sqft = 550,
        Amenity = "",
        CreatedDate = DateTime.Now,
        CreatedBy = "Abdou",
        UpdateDate = DateTime.Now
    }

    );
  }
    }
}
  

