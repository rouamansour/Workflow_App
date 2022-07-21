using Data.Models;

namespace BLL.Interface
{
    public interface IRequestService
    {
        public Task<IEnumerable<Request>> GetRequests();
        public Task CreateRequest(Request request);

    }
}
