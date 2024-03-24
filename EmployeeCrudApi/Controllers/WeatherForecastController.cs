using Microsoft.AspNetCore.Mvc;
using EmployeeCrudApi.Employees.Model;
using EmployeeCrudApi.Employees.Repository.Interfaces;
using EmployeeCrudApi.Employees.Repository;
namespace EmployeeCrudApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IEmployeeRepository _employeeRepository;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IEmployeeRepository employeeRepository)
        {
            _logger = logger;
            _employeeRepository = employeeRepository;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpGet("TEST")]
        public async Task<ActionResult<IEnumerable<Employee>>> GetAll()
        {
            var emp = await _employeeRepository.GetAllAsync();
            return Ok(emp);
        }
    }
}