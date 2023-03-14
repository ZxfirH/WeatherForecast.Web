using Microsoft.AspNetCore.Mvc;
using WeatherForecast.Web.Services.Interfaces;

namespace WeatherForecast.Web.Controllers
{
    public class SortedController : Controller
    {
        private readonly IWeatherForecastService _service;

        public SortedController(IWeatherForecastService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        public async Task<IActionResult> SortedIndex()
        {
            var products = await _service.Find();
            return View(products);
        }
    }
}