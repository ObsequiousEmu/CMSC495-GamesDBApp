using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamesDBApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GamesDBApp.Data
{
    public class RatingsContext : DbContext
    {
        public RatingsContext(DbContextOptions<RatingsContext> options) : base(options)
        {
        }

        public DbSet<RatingViewModel> Ratings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RatingViewModel>().ToTable("Rating");
        } 
    }
}
