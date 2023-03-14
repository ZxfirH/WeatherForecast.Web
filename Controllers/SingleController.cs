using Microsoft.AspNetCore.Mvc;
using WeatherForecast.Web.Services.Interfaces;

namespace WeatherForecast.Web.Controllers
{
    public class SingleController : Controller
    {
        private readonly IWeatherForecastService _service;

        public SingleController(IWeatherForecastService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        public async Task<IActionResult> SingleIndex()
        {
            var products = await _service.Find();
            return View(products);
        }
    }
}