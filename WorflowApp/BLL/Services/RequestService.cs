using BLL.Interface;
using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL.Services
{
    public class RequestService : IRequestService
    {
        private readonly WorkflowDbContext _db;

        public RequestService(WorkflowDbContext db)
        {
            _db = db;
        }

        public async Task CreateRequest(Request request)
        {
            await _db.Requests.AddAsync(request);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Request>> GetRequests()
        {
            return await _db.Requests.ToListAsync();
        }

    }
}
