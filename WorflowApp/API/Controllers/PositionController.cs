using BLL.Interface;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionController : ControllerBase
    {
        private readonly ILogger<RequestController> _logger;
        private readonly IPositionService _positionService;

        public PositionController(ILogger<RequestController> logger, IPositionService requestService)
        {
            _logger = logger;
            _positionService = requestService;
        }

        [HttpGet]
        public async Task<IEnumerable<Position>> Get()
        {
            return await _positionService.GetPositionts();
        }

        [HttpPost]
        public async Task Create([FromBody] Position position)
        {
            await _positionService.CreatePosition(position);
        }
    }
}
