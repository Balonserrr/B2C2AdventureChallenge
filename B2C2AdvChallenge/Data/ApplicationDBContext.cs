using B2C2AdvChallenge.Models;
using Microsoft.EntityFrameworkCore;

namespace B2C2AdvChallenge.Data;
public class ApplicationDBContext :DbContext
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
    {

    }
    public DbSet<Category> Categories { get; set; }
}

