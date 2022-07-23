using Data.Models;

namespace BLL.Interface
{
    public interface IPositionService
    {
        public Task<IEnumerable<Position>> GetPositionts();
        public Task CreatePosition(Position position);
    }
}
