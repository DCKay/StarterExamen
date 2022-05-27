using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project1.Business;
using Project1.Models.Items;

namespace Project1.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class MousematController : ControllerBase
    {
        private ILogger<Mousemat> _logger;
        private IMousematService _service;

        public MousematController(ILogger<Mousemat> logger, IMousematService service)
        {
            _logger = logger;
            _service = service;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mousemat>>> Get()
        {
            return Ok(await _service.GetAsync());
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task AddMousemat(Mousemat mousemat)
        {
            await _service.AddMousemat(mousemat);
        }
    }
}