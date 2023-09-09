using Microsoft.AspNetCore.Mvc;
using System;

namespace MVCTestProject.Controllers
{
    [ApiController]
    [Route("api")]
    public class ApiController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string slack_name, string track)
        {
            var currentUtcTime = DateTime.UtcNow;
            var currentDay = DateTime.UtcNow.ToString("dddd");

            // Create the response JSON object
            var response = new
            {
                slack_name = "Aderibigbe Musodiq Olamide",
                current_day = currentDay,
                utc_time = currentUtcTime.ToString("yyyy-MM-ddTHH:mm:ssZ"),
                track = "backend",
                github_file_url = "https://github.com/aderibigbeolamide/MVCTestProject/blob/master/Controllers/ApiController.cs",
                github_repo_url = "https://github.com/aderibigbeolamide",
                status_code = 200
            };

            return Ok(response);
        }
    }
}
