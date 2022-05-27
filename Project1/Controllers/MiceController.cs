using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project1.Business;
using Project1.Models.Items;

namespace Project1.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class MiceController : ControllerBase
    {
        private ILogger<Mice> _logger;
        private IMiceService _service;

        public MiceController(ILogger<Mice> logger, IMiceService service)
        {
            _logger = logger;
            _service = service;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mice>>> Get()
        {
            return Ok(await _service.GetAsync());
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task AddMice(Mice mice)
        {
            await _service.AddMice(mice);
        }
    }
}