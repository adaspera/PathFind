using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PathAPI.Models;

namespace PineAPP.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options)
        : base(options) { }
    
    public DbSet<Location> Location { get; set; }
    
}