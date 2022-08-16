using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace p2.Models;

public class Voluenteer_Pet
{
    [Required] public DateTime DateAccepted { get; set; }

    public int IdVoluenteer { get; set; }
    [ForeignKey("IdVoluenteer")] public Voluenteer Voluenteer { get; set; }
    public int IdPet { get; set; }
    [ForeignKey("IdPet")] public Pet Pet { get; set; }
}