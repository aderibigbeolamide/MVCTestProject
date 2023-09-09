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
            // Get the current UTC time
            var currentUtcTime = DateTime.UtcNow;

            // Determine the current day of the week
            var currentDay = DateTime.UtcNow.ToString("dddd");

            // Create the response JSON object
            var response = new
            {
                slack_name = "HNGx",
                current_day = currentDay,
                utc_time = currentUtcTime.ToString("yyyy-MM-ddTHH:mm:ssZ"),
                track = "Backend",
                github_file_url = "https://github.com/aderibigbeolamide/My-Portfolio",
                github_repo_url = "https://github.com/aderibigbeolamide",
                status_code = 200
            };

            return Ok(response);
        }
    }
}
