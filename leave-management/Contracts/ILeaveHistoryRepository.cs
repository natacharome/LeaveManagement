﻿using leave_management.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Contracts
{
    public interface ILeaveHistory : IRepositoryBase<LeaveHistory>
    {
    }
}
