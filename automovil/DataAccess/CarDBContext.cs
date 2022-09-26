using automovil.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace automovil.DataAccess
{
    public class CarDBContext :DbContext
    {
        public CarDBContext(DbContextOptions<CarDBContext> options) : base(options)
        {

        }
        // add DB sets (Tables)
        public DbSet<Curso>? Curso { get; set; }
    }
}
