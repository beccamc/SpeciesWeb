using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SpeciesWeb.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SpeciesWeb.Pages
{
    public class DownloadModel : PageModel
    {
        private readonly IWebHostEnvironment _env;
        private readonly WeatherForecastService _forecastService;
        public DownloadModel(IWebHostEnvironment env, WeatherForecastService weatherForecastService)
        {
            _env = env;
            _forecastService = weatherForecastService;
        }
        public async Task<IActionResult> OnGetAsync(byte[] testObj)
        {
            //get forecast from forecast service
            //var forecasts = await _forecastService.GetForecastAsync(DateTime.Now);
            //var jsonstr = System.Text.Json.JsonSerializer.Serialize(forecasts);
            //byte[] byteArray = System.Text.Encoding.ASCII.GetBytes(jsonstr);

            return File(testObj, "application/force-download", "new_file.json");
        }
    }
}
