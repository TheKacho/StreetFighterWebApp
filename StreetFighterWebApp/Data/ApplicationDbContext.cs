using Microsoft.EntityFrameworkCore;
using StreetFighterWebApp.Models;

namespace StreetFighterWebApp.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<ESportGroup> EsportGroups { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
