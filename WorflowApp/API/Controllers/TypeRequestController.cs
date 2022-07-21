using BLL.Interface;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeRequestController : ControllerBase
    {
        private readonly ILogger<TypeRequestController> _logger;
        private readonly ITypeRequestService _typeRequestService;

        public TypeRequestController(ILogger<TypeRequestController> logger, ITypeRequestService requestService)
        {
            _logger = logger;
            _typeRequestService = requestService;
        }

        [HttpGet]
        public async Task<IEnumerable<TypeRequest>> Get()
        {
            return await _typeRequestService.GetTypeRequests();
        }

        [HttpPost]
        public async Task Create([FromBody] TypeRequest demande)
        {
            await _typeRequestService.CreateTypeRequest(demande);
        }
    }
}
