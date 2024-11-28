using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {
        public ActionResult Get() {
            return Ok("pippo");
        }
    }
}
