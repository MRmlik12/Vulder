using System.Collections.Generic;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;

namespace Vulder.Search.Api.Controllers
{
    [ApiController]
    [Route("/")]
    public class IndexController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(new Dictionary<string, string>
            {
                { "version", Assembly.GetExecutingAssembly().GetName().Version?.ToString() }
            });
        }
    }
}