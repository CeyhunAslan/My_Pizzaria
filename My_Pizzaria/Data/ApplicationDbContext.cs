using Microsoft.EntityFrameworkCore;
using My_Pizzaria.Models;

namespace My_Pizzaria.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
