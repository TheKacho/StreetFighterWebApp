using System.ComponentModel.DataAnnotations;

namespace StreetFighterWebApp.Models
{
    public class AppUser
    {
        [Key]
        public string? Id { get; set; }
        public string? Character { get; set; }
        public int? Matches { get; set; }
        public Address? Address { get; set; }
        public ICollection<ESportGroup> EsportsTeams { get; set; }
        public ICollection<Tournament> Tournaments { get; set; }
    }
}
