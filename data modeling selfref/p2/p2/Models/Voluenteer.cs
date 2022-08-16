using System.ComponentModel.DataAnnotations;

namespace p2.Models;

public class Voluenteer
{
    [Key] public int IdVoluenteer { get; set; }

    [Required, MaxLength(50, ErrorMessage = " max lenght 50")]
    public string Name { get; set; }

    [Required, MaxLength(50, ErrorMessage = " max lenght 50")]
    public string Surname { get; set; }

    /*  [Required, MaxLength(50, ErrorMessage = " max lenght 50")]
      public string Phone { get; set; }
  
      [Required, MaxLength(100, ErrorMessage = " max lenght 100")]
      public string Address { get; set; }
  
      [Required, MaxLength(50, ErrorMessage = " max lenght 50")]
      public string Email { get; set; }
      */

    [Required] public DateTime StartingDate { get; set; }

    public int IdSupervisor { get; set; }
    public Voluenteer Supervisor { get; set; }
    public ICollection<Voluenteer_Pet> VoluenteerPets { get; set; } = new HashSet<Voluenteer_Pet>();
}