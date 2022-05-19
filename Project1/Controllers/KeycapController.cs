using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project1.Business;
using Project1.Models;

namespace Project1.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class KeycapController : ControllerBase
    {
        private ILogger<Keycap> _logger;
        private IKeycapService _service;

        public KeycapController(ILogger<Keycap> logger, IKeycapService service)
        {
            _logger = logger;
            _service = service;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Keycap>>> Get()
        {
            return Ok(await _service.GetAsync());
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task AddKeycap(Keycap keycap)
        {
            await _service.AddKeycap(keycap);
        }
    }
}