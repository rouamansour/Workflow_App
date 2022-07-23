using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using BLL.Interface;

namespace BLL.Services
{
    public class PositionService : IPositionService
    {
        private readonly WorkflowDbContext _db;

        public PositionService(WorkflowDbContext db)
        {
            _db = db;
        }

        public async Task CreatePosition(Position position)
        {
            await _db.Positions.AddAsync(position);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Position>> GetPositionts()
        {
            return await _db.Positions.ToListAsync();
        }
    }
}
