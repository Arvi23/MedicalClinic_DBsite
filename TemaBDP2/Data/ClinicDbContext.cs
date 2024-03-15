using Microsoft.EntityFrameworkCore;
using System;
namespace TemaBD.Models;

public class ClinicDbContext : DbContext
{
    public ClinicDbContext(DbContextOptions<ClinicDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Pacient> Pacienti { get; set; }
    public DbSet<Consultatie> Consultatii { get; set; }
    public DbSet<Medic> Medici { get; set; }
    public DbSet<Serviciu> Servicii { get; set; }
    public DbSet<DetaliiConsultatie> DetaliiConsultatii { get; set; }
}
