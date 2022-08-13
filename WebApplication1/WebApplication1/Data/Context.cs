using System.Collections.Immutable;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data;

public class Context:DbContext
{
    public Context()
    {
        
    }

    public Context(DbContextOptions options):base(options)
    {
        
    }


    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Medicament> Medicaments { get; set; }
    public DbSet<Prescription> Prescriptions { get; set; }
    public DbSet<Prescription_Medicament> PrescriptionMedicaments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<Doctor>(e =>
            e.HasData(new Doctor {IdDoctor = 1, FirstName = "1", LastName = "1", Email = "1"})
        );
        modelBuilder.Entity<Patient>(e =>
            e.HasData(new Patient
                {IdPatient = 1, FirstName = "1", LastName = "2", Birthdate = new DateTime(2000, 03, 03)})
        );
        modelBuilder.Entity<Medicament>(e =>
            e.HasData(new Medicament {IdMedicament = 1, Name = "Zeynep", Type = "dksdks", Description = "sjdsjds"})
            );
        modelBuilder.Entity<Prescription>(e => e.HasData(new Prescription
            {IdPrescription = 1, Date = new DateTime(2000,2,2), 
                DueDate = new DateTime(2000,2,2), IdDoctor = 1, IdPatient = 1})
        );
        
        modelBuilder.Entity<Prescription_Medicament>(e =>
        {
            e.HasKey(x => new {x.IdMedicament, x.IdPrescription});
            e.HasData(new Prescription_Medicament
            {
                IdMedicament = 1, IdPrescription = 1, Dose = 1, Details = "jsjdd"
            });
        });
        
        base.OnModelCreating(modelBuilder);
    }
}