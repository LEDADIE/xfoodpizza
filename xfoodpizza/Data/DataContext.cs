using Microsoft.EntityFrameworkCore;

using xfoodpizza.Models;

namespace xfoodpizza.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Pizza> Pizzas { get; set; }
}