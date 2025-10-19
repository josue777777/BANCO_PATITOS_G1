using G1PROYECTOAPIC_.Data;
using G1PROYECTOAPIC_.Models;
using Microsoft.AspNetCore.Mvc;

namespace G1PROYECTOAPIC_.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        //El controller une la vista con la logica 
        //CRUD POST/GET/PUT/DELETE

        private readonly AppDbContext _context;
    }
}
