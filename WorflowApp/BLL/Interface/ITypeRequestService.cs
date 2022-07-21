using Data.Models;

namespace BLL.Interface
{
    public interface ITypeRequestService
    {
        public Task<IEnumerable<TypeRequest>> GetTypeRequests();
        public Task CreateTypeRequest(TypeRequest typeRequest);
    }
}
