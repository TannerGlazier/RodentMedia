using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RodentMedia.Models
{
    public class RodentMediaContext : DbContext
    {
        // constructor
        public RodentMediaContext (DbContextOptions <RodentMediaContext> options) : base(options)
        {
            //Leave blank for now
        }

        public DbSet<RatMedia> RatMedia { get; set; }
        public DbSet<MediaType> MediaTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MediaType>().HasData(
                new MediaType { MediaTypeId = 1, MediaTypeName= "Movie" },
                new MediaType { MediaTypeId = 2, MediaTypeName = "Book" },
                new MediaType { MediaTypeId = 3, MediaTypeName = "Television" },
                new MediaType { MediaTypeId = 4, MediaTypeName = "Music" },
                new MediaType { MediaTypeId = 5, MediaTypeName = "Image" },
                new MediaType { MediaTypeId = 6, MediaTypeName = "Theater" },
                new MediaType { MediaTypeId = 7, MediaTypeName = "Printed Publication" },
                new MediaType { MediaTypeId = 8, MediaTypeName = "Other" }
                );

            // Seed Data
            mb.Entity<RatMedia>().HasData(
                new RatMedia
                {
                    MediaId = 1,
                    Image = "https://images-na.ssl-images-amazon.com/images/I/916JW20V3yL.jpg",
                    MediaName = "Charlotte's Web",
                    RatName = "Templeton",
                    Year = 1952,
                    MediaTypeId = 2,
                    Description = "Templeton is a rat who helps Charlotte and Wilbur only when offered food. He serves as a somewhat caustic, self-serving comic relief to the plot."

                },
                new RatMedia
                {
                    MediaId = 2,
                    Image = "https://resizing.flixster.com/gL_JpWcD7sNHNYSwI1ff069Yyug=/ems.ZW1zLXByZC1hc3NldHMvbW92aWVzLzc4ZmJhZjZiLTEzNWMtNDIwOC1hYzU1LTgwZjE3ZjQzNTdiNy5qcGc=",
                    MediaName = "Ratatouille",
                    RatName = "Remy",
                    Year = 2007,
                    MediaTypeId = 1,
                    Description = "The main protagonist who befriends a worker at a famous Parisian restaurant and assists him in his culinary career."
                },
                new RatMedia
                {
                    MediaId = 3,
                    Image = "https://images-na.ssl-images-amazon.com/images/I/81TxVwDLFnL.jpg",
                    MediaName = "The Nutcracker",
                    RatName = "The Rat King",
                    Year = 1892,
                    MediaTypeId = 6,
                    Description = "During the night, the Rat King and his army fight against the Nutcracker and his fellow toy soldiers."
                }


                );
        }
    }
}
