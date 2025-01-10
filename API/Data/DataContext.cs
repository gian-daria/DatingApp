using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

// public class DataContext : DbContext
// {
//     public DataContext(DbContextOptions options) : base(options)
//     {
//     }
// }

public class DataContext(DbContextOptions options) : DbContext(options) // primary constructor
{
    public DbSet<AppUser> Users { get; set; }
}

