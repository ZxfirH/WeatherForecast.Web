using Microsoft.AspNetCore.Mvc;
using WeatherForecast.Web.Services.Interfaces;

namespace WeatherForecast.Web.Controllers
{
    public class AllController : Controller
    {
        private readonly IWeatherForecastService _service;

        public AllController(IWeatherForecastService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        public async Task<IActionResult> AllIndex()
        {
            var products = await _service.Find();
            return View(products);
        }
    }
}