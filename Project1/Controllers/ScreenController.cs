using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project1.Business;
using Project1.Models;

namespace Project1.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ScreenController : ControllerBase
    {
        private ILogger<Screen> _logger;
        private IScreenService _service;

        public ScreenController(ILogger<Screen> logger, IScreenService service)
        {
            _logger = logger;
            _service = service;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Screen>>> Get()
        {
            return Ok(await _service.GetAsync());
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task AddScreen(Screen screen)
        {
            await _service.AddScreen(screen);
        }
    }
}