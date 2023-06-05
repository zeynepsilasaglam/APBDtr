using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class Doctor
{
    [Key]
    public int IdDoctor { get; set; }
    [Required,MaxLength(100, ErrorMessage = "max lenght is 100")]
    public string FirstName { get; set; }
    [Required,MaxLength(100, ErrorMessage = "max lenght is 100")]
    public string LastName  { get; set; }
    [Required,MaxLength(100, ErrorMessage = "max lenght is one hunderd")]
    public string Email { get; set; }
    
    public ICollection<Prescription> Prescriptions { get; set; } = new HashSet<Prescription>();

}