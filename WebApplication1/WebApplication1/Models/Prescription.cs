using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;

public class Prescription
{
    [Key]
    public int IdPrescription { get; set; }
    [Required]
    public DateTime Date { get; set; }
    [Required]
    //[DataType(DataType.Date)]
    public DateTime DueDate { get; set; }
    
    public int IdPatient { get; set; }
    [ForeignKey("IdPatient")] 
    public Patient Patient { get; set; }
    
    public int IdDoctor { get; set; }
    [ForeignKey("IdDoctor")] 
    public Doctor Doctor { get; set; }
    
    public ICollection<Prescription_Medicament> PrescriptionMedicaments { get; set; } = new HashSet<Prescription_Medicament>();

    
}