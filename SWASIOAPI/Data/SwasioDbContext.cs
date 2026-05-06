using Microsoft.EntityFrameworkCore;
using SWASIOAPI.Models;

namespace SWASIOAPI.Data;

public class SwasioDbContext(DbContextOptions<SwasioDbContext> options) : DbContext(options)
{
    public DbSet<Patient> Patients => Set<Patient>();
}
