using BLL.Interface;
using Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        private readonly ILogger<RequestController> _logger;
        private readonly IRequestService _requestService;

        public RequestController(ILogger<RequestController> logger, IRequestService requestService)
        {
            _logger = logger;
            _requestService = requestService;
        }

        [HttpGet]
        public async Task<IEnumerable<Request>> Get()
        {
            return await _requestService.GetRequests();
        }

        [HttpPost]
        public async Task Create([FromBody] Request demande)
        {
            await _requestService.CreateRequest(demande);
        }



    }
}
