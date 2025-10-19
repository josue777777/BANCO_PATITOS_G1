using G1PROYECTOAPIC_.Models;
using Microsoft.EntityFrameworkCore;

namespace G1PROYECTOAPIC_.Data
{
    public class AppDbContext : DbContext
    {

        // constructor vacio
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }





        // DbSet para la entidad del modelo (hay que eliminarla es una prueba) 
       /* public DbSet<WeatherForecastModel> Producto { get; set; }*/

    }
}