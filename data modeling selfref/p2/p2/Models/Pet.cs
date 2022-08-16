using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace p2.Models;

public class Pet
{
    [Key] public int IdPet { get; set; }

    [Required, MaxLength(50, ErrorMessage = " max lenght 50")]
    public string Name { get; set; }

    [Required] public bool isMale { get; set; }
    [Required] public DateTime DateRegistered { get; set; }
    [Required] public DateTime ApproximateDateOfBirth { get; set; }
    public DateTime DateAdopted { get; set; }
    public int IdBreedType { get; set; }
    [ForeignKey("IdBreedType")] public BreedType BreedType { get; set; }
    public ICollection<Voluenteer_Pet> VoluenteerPets { get; set; } = new HashSet<Voluenteer_Pet>();

}