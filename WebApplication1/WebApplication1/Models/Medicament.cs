using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class Medicament
{
    [Key]
    public int IdMedicament { get; set; }
    [Required,MaxLength(100, ErrorMessage = "max lenght is 100")]
    public string Name { get; set; }
    [Required,MaxLength(100, ErrorMessage = "max lenght is 100")]
    public string Description { get; set; }
    [Required,MaxLength(100, ErrorMessage = "max lenght is 100")]
    public string Type { get; set; }
    public ICollection<Prescription_Medicament> PrescriptionMedicaments { get; set; } = new HashSet<Prescription_Medicament>();

}