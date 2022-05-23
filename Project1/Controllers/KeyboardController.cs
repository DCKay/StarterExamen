using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project1.Business;
using Project1.Models;
using Project1.Models.Items;

namespace Project1.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class KeyboardController : ControllerBase
    {
        private ILogger<Keyboard> _logger;
        private IKeyboardService _service;

        public KeyboardController(ILogger<Keyboard> logger, IKeyboardService service)
        {
            _logger = logger;
            _service = service;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Keyboard>>> Get()
        {
            return Ok(await _service.GetAsync());
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task AddKeyboard(Keyboard keyboard)
        {
            await _service.AddKeyboard(keyboard);
        }
    }
}