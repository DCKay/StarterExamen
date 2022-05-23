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
    public class HeadsetController : ControllerBase
    {
        private ILogger<Headset> _logger;
        private IHeadsetService _service;

        public HeadsetController(ILogger<Headset> logger, IHeadsetService service)
        {
            _logger = logger;
            _service = service;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Headset>>> Get()
        {
            return Ok(await _service.GetAsync());
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task AddHeadset(Headset headset)
        {
            await _service.AddHeadset(headset);
        }
    }
}