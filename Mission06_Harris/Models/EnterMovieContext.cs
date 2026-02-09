using Microsoft.EntityFrameworkCore;

namespace Mission06_Harris.Models;

public class EnterMovieContext : DbContext
{
    public EnterMovieContext(DbContextOptions<EnterMovieContext> options) : base(options) //constructor
    {
        
    }
    public DbSet<MovieForm> Movies { get; set; }
}