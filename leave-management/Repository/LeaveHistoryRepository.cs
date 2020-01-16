using leave_management.Contracts;
using leave_management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Repository
{
    public class LeaveHistoryRepository : ILeaveHistoryRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveHistoryRepository(ApplicationDbContext context)
        {
            _db = context;
        }
        public bool Create(LeaveHistoryRepository entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(LeaveHistoryRepository entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<LeaveHistoryRepository> FindAll()
        {
            throw new NotImplementedException();
        }

        public LeaveHistoryRepository FindById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(LeaveHistoryRepository entity)
        {
            throw new NotImplementedException();
        }
    }
}
