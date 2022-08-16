using System.ComponentModel.DataAnnotations;

namespace p2.Models;

public class BreedType
{
    [Key] public int IdBreedType { get; set; }

    [Required, MaxLength(50, ErrorMessage = " max lenght 50")]
    public string Name { get; set; }

    [MaxLength(500, ErrorMessage = " max lenght 500")]
    public string Description { get; set; }

    public ICollection<Pet> Pets { get; set; } = new HashSet<Pet>();
}