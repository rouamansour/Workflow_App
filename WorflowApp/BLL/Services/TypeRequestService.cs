using BLL.Interface;
using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class TypeRequestService : ITypeRequestService
    {
        private readonly WorkflowDbContext _db;

        public TypeRequestService(WorkflowDbContext db)
        {
            _db = db;
        }

        public async Task CreateTypeRequest(TypeRequest typeRequest)
        {
            await _db.TypeRequests.AddAsync(typeRequest);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<TypeRequest>> GetTypeRequests()
        {
            return await _db.TypeRequests.ToListAsync();
        }
    }
}
