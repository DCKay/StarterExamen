using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project1.Business;
using Project1.Models;

namespace Project1.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ComputerController: ControllerBase
    {
        private ILogger<Computer> _logger;
        private IComputerService _service;

        public ComputerController(ILogger<Computer> logger, IComputerService service)
        {
            _logger = logger;
            _service = service; 
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Computer>>> Get()
        {
            return Ok(await _service.GetAsync());
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task AddComputer(Computer computer)
        {
            await _service.AddComputer(computer);
        }
    }
}
