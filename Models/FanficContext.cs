using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fanfic.by.Models
{
    public class FanficContext : DbContext
    {
        public DbSet<Fanfic> Fanfics { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<ImageFanfic> Images { get; set; }
        public DbSet<Like> Likes { get; set; }

        public FanficContext(DbContextOptions<FanficContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
