using Microsoft.EntityFrameworkCore;
using NZWalksAPI.Model.Domain;

namespace NZWalksAPI.Data
{
    public class NZWalkDBContext : DbContext
    {
        public NZWalkDBContext(DbContextOptions<NZWalkDBContext> options) : base(options)
        {

        }
        public DbSet<Region> Region { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
    }
}
