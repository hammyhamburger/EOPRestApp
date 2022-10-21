using EOPServer.Entities;
using Microsoft.EntityFrameworkCore;

namespace EOPServer.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<AppUser> Users { get; set; }
}