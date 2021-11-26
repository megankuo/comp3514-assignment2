using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class SpeakerContext : DbContext
    {
        public SpeakerContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {

        }

        // Defalt sets tables to be plural if not overridden with above ToTable()
        public DbSet<Speaker> Speakers { get; set; }

    }
}