using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers{
    
    [ApiController]
    [Route("/api")]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet("healthCheck")]
        public ActionResult HealthCheck()
        {
            return Ok();
        }
    }
}
