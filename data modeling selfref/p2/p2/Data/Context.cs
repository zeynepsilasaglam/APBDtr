using Microsoft.EntityFrameworkCore;
using p2.Models;

namespace p2.Data;

public class Context : DbContext
{
    public Context()
    {
    }

    public Context(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Pet> Pets { get; set; }
    public DbSet<BreedType> BreedTypes { get; set; }
    public DbSet<Voluenteer> Voluenteers { get; set; }
    public DbSet<Voluenteer_Pet> VoluenteerPets { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BreedType>(e =>
            e.HasData(new BreedType {IdBreedType = 1, Description = "ddkd", Name = "djdjd"}));
        modelBuilder.Entity<Pet>(e =>
            e.HasData(new Pet
            {
                IdPet = 1, isMale = false, Name = "djjdjd", DateAdopted = new DateTime(2022, 03, 03),
                ApproximateDateOfBirth = new DateTime(2020, 03, 03), DateRegistered = new DateTime(2021, 03, 03),
                IdBreedType = 1
            }));
        modelBuilder.Entity<Voluenteer>(e =>
        {
            e.HasOne(s => s.Supervisor).WithMany().HasForeignKey(e => e.IdSupervisor).IsRequired(false);
            e.HasData(new Voluenteer
            {
                IdVoluenteer = 1, Name = "sjdj", Surname = "jsjdd", StartingDate = new DateTime(2022, 03, 03), IdSupervisor = 1
            });
        });
        modelBuilder.Entity<Voluenteer_Pet>(e =>
        {
            e.HasKey(x => new {x.IdPet, x.IdVoluenteer});
            e.HasData(new Voluenteer_Pet {IdPet = 1, DateAccepted = new DateTime(2022, 03, 03), IdVoluenteer = 1});
        });
        base.OnModelCreating(modelBuilder);
    }
}