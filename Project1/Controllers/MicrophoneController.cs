using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project1.Business;
using Project1.Models.Items;

namespace Project1.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class MicrophoneController : ControllerBase
    {
        private ILogger<Microphone> _logger;
        private IMicrophoneService _service;

        public MicrophoneController(ILogger<Microphone> logger, IMicrophoneService service)
        {
            _logger = logger;
            _service = service;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Microphone>>> Get()
        {
            return Ok(await _service.GetAsync());
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task AddMicrophone(Microphone microphone)
        {
            await _service.AddMicrophone(microphone);
        }
    }
}