using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project1.Business;
using Project1.Models;

namespace Project1.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class KeySwitchController : ControllerBase
    {
        private ILogger<KeySwitch> _logger;
        private IKeySwitchService _service;

        public KeySwitchController(ILogger<KeySwitch> logger, IKeySwitchService service)
        {
            _logger = logger;
            _service = service;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<KeySwitch>>> Get()
        {
            return Ok(await _service.GetAsync());
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task AddKeySwitch(KeySwitch keySwitch)
        {
            await _service.AddKeySwitch(keySwitch);
        }
    }
}