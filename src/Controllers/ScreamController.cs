using FactoryMethodPattern.Domain.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace FactoryMethodPattern.Controllers
{
    [Route("api/Scream")]
    [ApiController]
    public class ScreamController : ControllerBase
    {
        private readonly IScreenService _screenService;
        public ScreamController(IScreenService screenService) 
        { 
            _screenService = screenService;
        }   

        [HttpGet]
        [Route("Encrypt")]
        public async Task<IActionResult> Get()
        {


            return Ok(_screenService.GetMessage());
        }
    }
}
