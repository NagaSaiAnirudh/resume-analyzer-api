using Microsoft.AspNetCore.Mvc;

namespace ResumeAnalyzer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResumeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Resume Analyzer API endpoint";
        }
    }
}
